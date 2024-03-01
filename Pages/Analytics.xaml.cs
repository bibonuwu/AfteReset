using System.Windows;
using System;
using System.Windows.Controls;

namespace WPFUIKitProfessional.Pages
{
    /// <summary>
    /// Lógica de interacción para Analytics.xaml
    /// </summary>
    public partial class Analytics : Page
    {
        public Analytics()
        {
            InitializeComponent();
        }

        private void Button_Click_22(object sender, System.Windows.RoutedEventArgs e)
        {
            try
            {
                // Замените этот URL на нужный вам адрес
                string url = "https://www.donationalerts.com/r/aibekbibon";

                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                // Обработка ошибки, например, показ сообщения пользователю
                MessageBox.Show($"Не удалось открыть ссылку: {ex.Message}");
            }
        }
    }
}
