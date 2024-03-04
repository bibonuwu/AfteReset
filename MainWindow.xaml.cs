using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPFUIKitProfessional.Themes;
using WPFUIKitProfessional.Pages;
using System.Diagnostics;

namespace WPFUIKitProfessional
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        

























        private void Themes_Click(object sender, RoutedEventArgs e)
        {
            if (Themes.IsChecked == true)
                ThemesController.SetTheme(ThemesController.ThemeTypes.Dark);
            else
                ThemesController.SetTheme(ThemesController.ThemeTypes.Light);
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnRestore_Click(object sender, RoutedEventArgs e)
        {
            if (WindowState == WindowState.Normal)
                WindowState = WindowState.Maximized;
            else
                WindowState = WindowState.Normal;
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void rdHome_Click(object sender, RoutedEventArgs e)
        {
            frameContent.Navigate(new Home());
        }

        private void rdAnalytics_Click(object sender, RoutedEventArgs e)
        {
            frameContent.Navigate(new Analytics());
        }

        private void rdMessages_Click(object sender, RoutedEventArgs e)
        {
            frameContent.Navigate(new Messages());
        }

        private void rdCollections_Click(object sender, RoutedEventArgs e)
        {
            frameContent.Navigate(new Collections());
        }

        private void rdUsers_Click(object sender, RoutedEventArgs e)
        {
            frameContent.Navigate(new Users());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string url = "https://github.com/Aibek2002/AfteReset/releases/";

            try
            {
                // Открытие URL в браузере по умолчанию
                Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                // Если произошла ошибка, показываем сообщение
                MessageBox.Show($"Не удалось открыть ссылку: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void rdNotifications_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void rdCollections_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void home_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void home_Loaded(object sender, RoutedEventArgs e)
        {
            //Name Start
            DisplayIPAddressUsingPowerShell1();
            //Name END
        }

        //Name start
        private void DisplayIPAddressUsingPowerShell1()
        {
            string psCommand = "$Env:UserName";
            string localIP = RunPowerShellCommand1(psCommand);
            MemoryInfoLabel.Content = localIP;
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
        //Name End
    }
}
