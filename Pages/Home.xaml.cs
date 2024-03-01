using Microsoft.Web.WebView2.Core;
using System.Windows;
using System.Windows.Controls;

namespace WPFUIKitProfessional.Pages
{
    /// <summary>
    /// Lógica de interacción para Home.xaml
    /// </summary>
    public partial class Home : Page
    {
        public Home()
        {
            InitializeComponent();
            InitializeAsync();
        }
        private async void InitializeAsync()
        {
            if (webView.CoreWebView2 == null)
            {
                await webView.EnsureCoreWebView2Async(null);
                webView.CoreWebView2.NewWindowRequested += CoreWebView2_NewWindowRequested;
            }
        }




        private void CoreWebView2_NewWindowRequested(object sender, CoreWebView2NewWindowRequestedEventArgs e)
        {
            e.Handled = true; // Отменяем стандартное создание нового окна
            webView.CoreWebView2.Navigate(e.Uri); // Загружаем запрашиваемый URL в текущем WebView2
        }

        // Обработчик NavigationStarting, если он вам нужен, оставляйте без изменений
        private void webView_NavigationStarting(object sender, CoreWebView2NavigationStartingEventArgs e)
        {
            // Ваша логика здесь, если необходимо
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (webView.CanGoBack)
            {
                webView.GoBack();
            }
        }
    }
}
