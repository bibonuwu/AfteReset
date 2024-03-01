using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WPFUIKitProfessional.Pages
{
    /// <summary>
    /// Lógica de interacción para Collections.xaml
    /// </summary>
    public partial class Collections : Page
    {
        public Collections()
        {
            InitializeComponent();

        }







       







        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            // Путь к нужному ключу реестра
            string keyPath = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Feeds";
            bool operationSuccess = false; // Флаг успешности операции

            try
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(keyPath, true) ?? Registry.CurrentUser.CreateSubKey(keyPath))
                {
                    if (key != null)
                    {
                        key.SetValue("ShellFeedsTaskbarViewMode", 2, RegistryValueKind.DWord);
                        operationSuccess = true;
                    }
                    else
                    {
                        // Если ключ не существует, его нужно создать, и затем создать параметры
                        using (RegistryKey newKey = Registry.CurrentUser.CreateSubKey(keyPath))
                        {
                            if (newKey != null)
                            {
                                newKey.SetValue("ShellFeedsTaskbarViewMode", 2, RegistryValueKind.DWord);

                            }
                        }
                    }

                }
            }
            catch
            {
                operationSuccess = false;
            }

            if (operationSuccess)
            {
                DeleteFolderButton1.Background = new SolidColorBrush(Colors.Green);
            }
            else
            {
                DeleteFolderButton1.Background = new SolidColorBrush(Colors.Red);
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            // Путь к нужному ключу реестра
            string keyPath = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Search";

            bool operationSuccess = false; // Флаг успешности операции
            try
            {
                // Открытие ключа реестра HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Themes\Personalize для изменения
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(keyPath, true))
                {
                    if (key != null)
                    {
                        // Установка значения параметра "AppsUseLightTheme" в 0
                        key.SetValue("SearchboxTaskbarMode", 1, RegistryValueKind.DWord);
                        // Установка значения параметра "SystemUsesLightTheme" в 0
                        key.SetValue("SearchboxTaskbarModePrevious", 2, RegistryValueKind.DWord);
                        // Установка значения параметра "AppsUseLightTheme" в 0
                        key.SetValue("TraySearchBoxVisible", 0, RegistryValueKind.DWord);
                        // Установка значения параметра "SystemUsesLightTheme" в 0
                        key.SetValue("TraySearchBoxVisibleOnAnyMonitor", 0, RegistryValueKind.DWord);

                        operationSuccess = true;
                    }
                    else
                    {
                        // Если ключ не существует, его нужно создать, и затем создать параметры
                        using (RegistryKey newKey = Registry.CurrentUser.CreateSubKey(keyPath))
                        {
                            if (newKey != null)
                            {
                                newKey.SetValue("SearchboxTaskbarMode", 1, RegistryValueKind.DWord);
                                newKey.SetValue("SearchboxTaskbarModePrevious", 2, RegistryValueKind.DWord);
                                newKey.SetValue("TraySearchBoxVisible", 0, RegistryValueKind.DWord);
                                newKey.SetValue("TraySearchBoxVisibleOnAnyMonitor", 0, RegistryValueKind.DWord);
                            }
                        }
                    }
                }

            }
            catch
            {
                operationSuccess = false;
            }

            if (operationSuccess)
            {
                DeleteFolderButton2.Background = new SolidColorBrush(Colors.Green);
            }
            else
            {
                DeleteFolderButton2.Background = new SolidColorBrush(Colors.Red);
            }

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            // Путь к нужному ключу реестра
            string keyPath = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced";

            bool operationSuccess = false; // Флаг успешности операции
            try
            {
                // Открытие ключа реестра HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Themes\Personalize для изменения
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(keyPath, true))
                {
                    if (key != null)
                    {
                        // Установка значения параметра "AppsUseLightTheme" в 0
                        key.SetValue("TaskbarGlomLevel", 1, RegistryValueKind.DWord);


                        operationSuccess = true;
                    }
                    else
                    {
                        // Если ключ не существует, его нужно создать, и затем создать параметры
                        using (RegistryKey newKey = Registry.CurrentUser.CreateSubKey(keyPath))
                        {
                            if (newKey != null)
                            {
                                newKey.SetValue("TaskbarGlomLevel", 1, RegistryValueKind.DWord);

                            }
                        }
                    }
                }
            }
            catch
            {
                operationSuccess = false;
            }

            if (operationSuccess)
            {
                DeleteFolderButton3.Background = new SolidColorBrush(Colors.Green);
            }
            else
            {
                DeleteFolderButton3.Background = new SolidColorBrush(Colors.Red);
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            // Путь к нужному ключу реестра
            string keyPath = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced";

            bool operationSuccess = false; // Флаг успешности операции
            try
            {
                // Открытие ключа реестра HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Themes\Personalize для изменения
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(keyPath, true))
                {
                    if (key != null)
                    {
                        // Установка значения параметра "AppsUseLightTheme" в 0
                        key.SetValue("ShowTaskViewButton", 0, RegistryValueKind.DWord);


                        operationSuccess = true;
                    }
                    else
                    {
                        // Если ключ не существует, его нужно создать, и затем создать параметры
                        using (RegistryKey newKey = Registry.CurrentUser.CreateSubKey(keyPath))
                        {
                            if (newKey != null)
                            {
                                newKey.SetValue("ShowTaskViewButton", 0, RegistryValueKind.DWord);

                            }
                        }
                    }
                }
            }
            catch
            {
                operationSuccess = false;
            }

            if (operationSuccess)
            {
                DeleteFolderButton5.Background = new SolidColorBrush(Colors.Green);
            }
            else
            {
                DeleteFolderButton5.Background = new SolidColorBrush(Colors.Red);
            }
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            // Путь к нужному ключу реестра
            string keyPath = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Themes\Personalize";

            bool operationSuccess = false; // Флаг успешности операции
            try
            {
                // Открытие ключа реестра HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Themes\Personalize для изменения
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(keyPath, true))
                {
                    if (key != null)
                    {
                        // Установка значения параметра "AppsUseLightTheme" в 0
                        key.SetValue("AppsUseLightTheme", 0, RegistryValueKind.DWord);
                        // Установка значения параметра "AppsUseLightTheme" в 0
                        key.SetValue("SystemUsesLightTheme", 0, RegistryValueKind.DWord);

                        operationSuccess = true;
                    }
                    else
                    {
                        // Если ключ не существует, его нужно создать, и затем создать параметры
                        using (RegistryKey newKey = Registry.CurrentUser.CreateSubKey(keyPath))
                        {
                            if (newKey != null)
                            {
                                newKey.SetValue("AppsUseLightTheme", 0, RegistryValueKind.DWord);
                                newKey.SetValue("SystemUsesLightTheme", 0, RegistryValueKind.DWord);
                            }
                        }
                    }
                }
            }
            catch
            {
                operationSuccess = false;
            }

            if (operationSuccess)
            {
                DeleteFolderButton6.Background = new SolidColorBrush(Colors.Green);
            }
            else
            {
                DeleteFolderButton6.Background = new SolidColorBrush(Colors.Red);
            }
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            // Пути к ключам реестра
            string pushNotificationsKeyPath = @"SOFTWARE\Microsoft\Windows\CurrentVersion\PushNotifications";
            string contentDeliveryManagerKeyPath = @"Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager";
            string userProfileEngagementKeyPath = @"Software\Microsoft\Windows\CurrentVersion\UserProfileEngagement";

            bool operationSuccess = true; // Предполагаем, что операция успешна

            try
            {
                // Отключение ToastEnabled
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(pushNotificationsKeyPath, true))
                {
                    if (key != null)
                    {
                        key.SetValue("ToastEnabled", 0, RegistryValueKind.DWord);
                    }
                    else
                    {
                        operationSuccess = false;
                    }
                }

                // Отключение ContentDeliveryManager
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(contentDeliveryManagerKeyPath, true))
                {
                    if (key != null)
                    {
                        key.SetValue("SubscribedContent-338389Enabled", 0, RegistryValueKind.DWord);
                        key.SetValue("SubscribedContent-338388Enabled", 0, RegistryValueKind.DWord);
                        key.SetValue("SubscribedContent-310093Enabled", 0, RegistryValueKind.DWord);
                    }
                    else
                    {
                        operationSuccess = false;
                    }
                }

                // Отключение UserProfileEngagement
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(userProfileEngagementKeyPath, true))
                {
                    if (key != null)
                    {
                        key.SetValue("ScoobeSystemSettingEnabled", 0, RegistryValueKind.DWord);
                    }
                    else
                    {
                        operationSuccess = false;
                    }
                }
            }
            catch
            {
                operationSuccess = false;
            }

            // Обновление цвета кнопки в зависимости от успеха операции
            DeleteFolderButton7.Background = operationSuccess ? new SolidColorBrush(Colors.Green) : new SolidColorBrush(Colors.Red);

        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            // Путь к нужному ключу реестра
            string keyPath = @"SOFTWARE\Microsoft\Clipboard";

            bool operationSuccess = false; // Флаг успешности операции
            try
            {
                // Открытие ключа реестра HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Themes\Personalize для изменения
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(keyPath, true))
                {
                    if (key != null)
                    {
                        // Установка значения параметра "AppsUseLightTheme" в 0
                        key.SetValue("EnableClipboardHistory", 0, RegistryValueKind.DWord);


                        operationSuccess = true;
                    }
                    else
                    {
                        // Если ключ не существует, его нужно создать, и затем создать параметры
                        using (RegistryKey newKey = Registry.CurrentUser.CreateSubKey(keyPath))
                        {
                            if (newKey != null)
                            {
                                newKey.SetValue("EnableClipboardHistory", 0, RegistryValueKind.DWord);

                            }
                        }
                    }
                }
            }
            catch
            {
                operationSuccess = false;
            }

            if (operationSuccess)
            {
                DeleteFolderButton8.Background = new SolidColorBrush(Colors.Green);
            }
            else
            {
                DeleteFolderButton8.Background = new SolidColorBrush(Colors.Red);
            }
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            // Путь к нужному ключу реестра
            string keyPathDWM = @"SOFTWARE\Microsoft\Windows\DWM";

            bool operationSuccessDWM = false; // Флаг успешности операции
            try
            {
                // Открытие ключа реестра HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\DWM для изменения
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(keyPathDWM, true))
                {
                    if (key != null)
                    {
                        // Установка значения параметра "AccentColor" в ffd77800
                        key.SetValue("AccentColor", unchecked((int)0xffd77800), RegistryValueKind.DWord);

                        operationSuccessDWM = true;
                    }
                    else
                    {
                        // Если ключ не существует, его нужно создать, и затем создать параметры
                        using (RegistryKey newKey = Registry.CurrentUser.CreateSubKey(keyPathDWM))
                        {
                            if (newKey != null)
                            {
                                newKey.SetValue("AccentColor", unchecked((int)0xffd77800), RegistryValueKind.DWord);

                                operationSuccessDWM = true;
                            }
                        }
                    }
                }
            }
            catch
            {
                operationSuccessDWM = false;
            }

            if (operationSuccessDWM)
            {
                // Здесь укажите свою логику для случая успешной операции,
                // например, изменение цвета фона другой кнопки и отображение уведомления об успехе
                // Например, для кнопки с именем NewButton
                DeleteFolderButton9.Background = new SolidColorBrush(Colors.Green);
            }
            else
            {
                // Здесь укажите свою логику для случая неудачной операции,
                // например, изменение цвета фона другой кнопки и отображение уведомления об ошибке
                DeleteFolderButton9.Background = new SolidColorBrush(Colors.Red);
            }
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            // Путь к нужному ключу реестра
            string keyPath = @"SOFTWARE\Microsoft\Windows\CurrentVersion\ContentDeliveryManager";


            bool operationSuccess = false; // Флаг успешности операции
            try
            {
                // Открытие ключа реестра HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Themes\Personalize для изменения
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(keyPath, true))
                {
                    if (key != null)
                    {
                        // Установка значения параметра "AppsUseLightTheme" в 0
                        key.SetValue("RotatingLockScreenEnabled", 0, RegistryValueKind.DWord);
                        // Установка значения параметра "AppsUseLightTheme" в 0
                        key.SetValue("RotatingLockScreenOverlayEnabled ", 0, RegistryValueKind.DWord);
                        // Установка значения параметра "AppsUseLightTheme" в 0
                        key.SetValue("SubscribedContent-338387Enabled", 0, RegistryValueKind.DWord);




                        operationSuccess = true;
                    }
                    else
                    {
                        // Если ключ не существует, его нужно создать, и затем создать параметры
                        using (RegistryKey newKey = Registry.CurrentUser.CreateSubKey(keyPath))
                        {
                            if (newKey != null)
                            {
                                newKey.SetValue("RotatingLockScreenEnabled", 0, RegistryValueKind.DWord);
                                newKey.SetValue("RotatingLockScreenOverlayEnabled ", 0, RegistryValueKind.DWord);
                                newKey.SetValue("SubscribedContent-338387Enabled", 0, RegistryValueKind.DWord);

                            }
                        }
                    }
                }
            }
            catch
            {
                operationSuccess = false;
            }

            if (operationSuccess)
            {
                DeleteFolderButton10.Background = new SolidColorBrush(Colors.Green);
            }
            else
            {
                DeleteFolderButton10.Background = new SolidColorBrush(Colors.Red);
            }
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            // Путь к нужному ключу реестра
            string keyPathLocation = @"SOFTWARE\Microsoft\Windows\CurrentVersion\CapabilityAccessManager\ConsentStore\location";

            bool operationSuccessLocation = false; // Флаг успешности операции
            try
            {
                // Открытие ключа реестра HKEY_CURRENT_USER\...\location для изменения
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(keyPathLocation, true))
                {
                    if (key != null)
                    {
                        // Установка значения параметра "Value" в "Deny"
                        key.SetValue("Value", "Deny", RegistryValueKind.String);

                        operationSuccessLocation = true;
                    }
                    else
                    {
                        // Если ключ не существует, его нужно создать, и затем установить параметр
                        using (RegistryKey newKey = Registry.CurrentUser.CreateSubKey(keyPathLocation))
                        {
                            if (newKey != null)
                            {
                                newKey.SetValue("Value", "Deny", RegistryValueKind.String);

                                operationSuccessLocation = true;
                            }
                        }
                    }
                }
            }
            catch
            {
                operationSuccessLocation = false;
            }

            if (operationSuccessLocation)
            {
                // Здесь укажите логику для успешной операции, например, изменение цвета фона кнопки и отображение уведомления
                // Пример для кнопки с именем "ChangeLocationAccessButton"
                DeleteFolderButton11.Background = new SolidColorBrush(Colors.Green);
            }
            else
            {
                // Логика для неудачной операции, например, изменение цвета фона кнопки и отображение уведомления об ошибке
                DeleteFolderButton11.Background = new SolidColorBrush(Colors.Red);
            }
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            // Путь к нужному ключу реестра
            string keyPathLocation = @"SOFTWARE\Microsoft\Windows\CurrentVersion\CapabilityAccessManager\ConsentStore\userNotificationListener";

            bool operationSuccessLocation = false; // Флаг успешности операции
            try
            {
                // Открытие ключа реестра HKEY_CURRENT_USER\...\location для изменения
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(keyPathLocation, true))
                {
                    if (key != null)
                    {
                        // Установка значения параметра "Value" в "Deny"
                        key.SetValue("Value", "Deny", RegistryValueKind.String);

                        operationSuccessLocation = true;
                    }
                    else
                    {
                        // Если ключ не существует, его нужно создать, и затем установить параметр
                        using (RegistryKey newKey = Registry.CurrentUser.CreateSubKey(keyPathLocation))
                        {
                            if (newKey != null)
                            {
                                newKey.SetValue("Value", "Deny", RegistryValueKind.String);

                                operationSuccessLocation = true;
                            }
                        }
                    }
                }
            }
            catch
            {
                operationSuccessLocation = false;
            }

            if (operationSuccessLocation)
            {
                // Здесь укажите логику для успешной операции, например, изменение цвета фона кнопки и отображение уведомления
                // Пример для кнопки с именем "ChangeLocationAccessButton"
                DeleteFolderButton12.Background = new SolidColorBrush(Colors.Green);
            }
            else
            {
                // Логика для неудачной операции, например, изменение цвета фона кнопки и отображение уведомления об ошибке
                DeleteFolderButton12.Background = new SolidColorBrush(Colors.Red);
            }
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            // Путь к нужному ключу реестра
            string keyPathLocation = @"SOFTWARE\Microsoft\Windows\CurrentVersion\CapabilityAccessManager\ConsentStore\activity";

            bool operationSuccessLocation = false; // Флаг успешности операции
            try
            {
                // Открытие ключа реестра HKEY_CURRENT_USER\...\location для изменения
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(keyPathLocation, true))
                {
                    if (key != null)
                    {
                        // Установка значения параметра "Value" в "Deny"
                        key.SetValue("Value", "Deny", RegistryValueKind.String);

                        operationSuccessLocation = true;
                    }
                    else
                    {
                        // Если ключ не существует, его нужно создать, и затем установить параметр
                        using (RegistryKey newKey = Registry.CurrentUser.CreateSubKey(keyPathLocation))
                        {
                            if (newKey != null)
                            {
                                newKey.SetValue("Value", "Deny", RegistryValueKind.String);

                                operationSuccessLocation = true;
                            }
                        }
                    }
                }
            }
            catch
            {
                operationSuccessLocation = false;
            }

            if (operationSuccessLocation)
            {
                // Здесь укажите логику для успешной операции, например, изменение цвета фона кнопки и отображение уведомления
                // Пример для кнопки с именем "ChangeLocationAccessButton"
                DeleteFolderButton13.Background = new SolidColorBrush(Colors.Green);
            }
            else
            {
                // Логика для неудачной операции, например, изменение цвета фона кнопки и отображение уведомления об ошибке
                DeleteFolderButton13.Background = new SolidColorBrush(Colors.Red);
            }
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            // Путь к нужному ключу реестра
            string keyPathLocation = @"SOFTWARE\Microsoft\Windows\CurrentVersion\CapabilityAccessManager\ConsentStore\userAccountInformation";

            bool operationSuccessLocation = false; // Флаг успешности операции
            try
            {
                // Открытие ключа реестра HKEY_CURRENT_USER\...\location для изменения
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(keyPathLocation, true))
                {
                    if (key != null)
                    {
                        // Установка значения параметра "Value" в "Deny"
                        key.SetValue("Value", "Deny", RegistryValueKind.String);

                        operationSuccessLocation = true;
                    }
                    else
                    {
                        // Если ключ не существует, его нужно создать, и затем установить параметр
                        using (RegistryKey newKey = Registry.CurrentUser.CreateSubKey(keyPathLocation))
                        {
                            if (newKey != null)
                            {
                                newKey.SetValue("Value", "Deny", RegistryValueKind.String);

                                operationSuccessLocation = true;
                            }
                        }
                    }
                }
            }
            catch
            {
                operationSuccessLocation = false;
            }

            if (operationSuccessLocation)
            {
                // Здесь укажите логику для успешной операции, например, изменение цвета фона кнопки и отображение уведомления
                // Пример для кнопки с именем "ChangeLocationAccessButton"
                DeleteFolderButton14.Background = new SolidColorBrush(Colors.Green);
            }
            else
            {
                // Логика для неудачной операции, например, изменение цвета фона кнопки и отображение уведомления об ошибке
                DeleteFolderButton14.Background = new SolidColorBrush(Colors.Red);
            }
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            // Путь к нужному ключу реестра
            string keyPathLocation = @"SOFTWARE\Microsoft\Windows\CurrentVersion\CapabilityAccessManager\ConsentStore\contacts";

            bool operationSuccessLocation = false; // Флаг успешности операции
            try
            {
                // Открытие ключа реестра HKEY_CURRENT_USER\...\location для изменения
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(keyPathLocation, true))
                {
                    if (key != null)
                    {
                        // Установка значения параметра "Value" в "Deny"
                        key.SetValue("Value", "Deny", RegistryValueKind.String);

                        operationSuccessLocation = true;
                    }
                    else
                    {
                        // Если ключ не существует, его нужно создать, и затем установить параметр
                        using (RegistryKey newKey = Registry.CurrentUser.CreateSubKey(keyPathLocation))
                        {
                            if (newKey != null)
                            {
                                newKey.SetValue("Value", "Deny", RegistryValueKind.String);

                                operationSuccessLocation = true;
                            }
                        }
                    }
                }
            }
            catch
            {
                operationSuccessLocation = false;
            }

            if (operationSuccessLocation)
            {
                // Здесь укажите логику для успешной операции, например, изменение цвета фона кнопки и отображение уведомления
                // Пример для кнопки с именем "ChangeLocationAccessButton"
                DeleteFolderButton15.Background = new SolidColorBrush(Colors.Green);
            }
            else
            {
                // Логика для неудачной операции, например, изменение цвета фона кнопки и отображение уведомления об ошибке
                DeleteFolderButton15.Background = new SolidColorBrush(Colors.Red);
            }
        }

        private void Button_Click_16(object sender, RoutedEventArgs e)
        {
            // Путь к нужному ключу реестра
            string keyPathLocation = @"SOFTWARE\Microsoft\Windows\CurrentVersion\CapabilityAccessManager\ConsentStore\appointments";

            bool operationSuccessLocation = false; // Флаг успешности операции
            try
            {
                // Открытие ключа реестра HKEY_CURRENT_USER\...\location для изменения
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(keyPathLocation, true))
                {
                    if (key != null)
                    {
                        // Установка значения параметра "Value" в "Deny"
                        key.SetValue("Value", "Deny", RegistryValueKind.String);

                        operationSuccessLocation = true;
                    }
                    else
                    {
                        // Если ключ не существует, его нужно создать, и затем установить параметр
                        using (RegistryKey newKey = Registry.CurrentUser.CreateSubKey(keyPathLocation))
                        {
                            if (newKey != null)
                            {
                                newKey.SetValue("Value", "Deny", RegistryValueKind.String);

                                operationSuccessLocation = true;
                            }
                        }
                    }
                }
            }
            catch
            {
                operationSuccessLocation = false;
            }

            if (operationSuccessLocation)
            {
                // Здесь укажите логику для успешной операции, например, изменение цвета фона кнопки и отображение уведомления
                // Пример для кнопки с именем "ChangeLocationAccessButton"
                DeleteFolderButton16.Background = new SolidColorBrush(Colors.Green);
            }
            else
            {
                // Логика для неудачной операции, например, изменение цвета фона кнопки и отображение уведомления об ошибке
                DeleteFolderButton16.Background = new SolidColorBrush(Colors.Red);
            }
        }

        private void Button_Click_17(object sender, RoutedEventArgs e)
        {
            // Путь к нужному ключу реестра
            string keyPathLocation = @"SOFTWARE\Microsoft\Windows\CurrentVersion\CapabilityAccessManager\ConsentStore\phoneCallHistory";

            bool operationSuccessLocation = false; // Флаг успешности операции
            try
            {
                // Открытие ключа реестра HKEY_CURRENT_USER\...\location для изменения
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(keyPathLocation, true))
                {
                    if (key != null)
                    {
                        // Установка значения параметра "Value" в "Deny"
                        key.SetValue("Value", "Deny", RegistryValueKind.String);

                        operationSuccessLocation = true;
                    }
                    else
                    {
                        // Если ключ не существует, его нужно создать, и затем установить параметр
                        using (RegistryKey newKey = Registry.CurrentUser.CreateSubKey(keyPathLocation))
                        {
                            if (newKey != null)
                            {
                                newKey.SetValue("Value", "Deny", RegistryValueKind.String);

                                operationSuccessLocation = true;
                            }
                        }
                    }
                }
            }
            catch
            {
                operationSuccessLocation = false;
            }

            if (operationSuccessLocation)
            {
                // Здесь укажите логику для успешной операции, например, изменение цвета фона кнопки и отображение уведомления
                // Пример для кнопки с именем "ChangeLocationAccessButton"
                DeleteFolderButton17.Background = new SolidColorBrush(Colors.Green);
            }
            else
            {
                // Логика для неудачной операции, например, изменение цвета фона кнопки и отображение уведомления об ошибке
                DeleteFolderButton17.Background = new SolidColorBrush(Colors.Red);
            }
        }

        private void Button_Click_18(object sender, RoutedEventArgs e)
        {
            // Путь к нужному ключу реестра
            string keyPathLocation = @"SOFTWARE\Microsoft\Windows\CurrentVersion\CapabilityAccessManager\ConsentStore\email";

            bool operationSuccessLocation = false; // Флаг успешности операции
            try
            {
                // Открытие ключа реестра HKEY_CURRENT_USER\...\location для изменения
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(keyPathLocation, true))
                {
                    if (key != null)
                    {
                        // Установка значения параметра "Value" в "Deny"
                        key.SetValue("Value", "Deny", RegistryValueKind.String);

                        operationSuccessLocation = true;
                    }
                    else
                    {
                        // Если ключ не существует, его нужно создать, и затем установить параметр
                        using (RegistryKey newKey = Registry.CurrentUser.CreateSubKey(keyPathLocation))
                        {
                            if (newKey != null)
                            {
                                newKey.SetValue("Value", "Deny", RegistryValueKind.String);

                                operationSuccessLocation = true;
                            }
                        }
                    }
                }
            }
            catch
            {
                operationSuccessLocation = false;
            }

            if (operationSuccessLocation)
            {
                // Здесь укажите логику для успешной операции, например, изменение цвета фона кнопки и отображение уведомления
                // Пример для кнопки с именем "ChangeLocationAccessButton"
                DeleteFolderButton18.Background = new SolidColorBrush(Colors.Green);
            }
            else
            {
                // Логика для неудачной операции, например, изменение цвета фона кнопки и отображение уведомления об ошибке
                DeleteFolderButton18.Background = new SolidColorBrush(Colors.Red);
            }
        }

        private void Button_Click_19(object sender, RoutedEventArgs e)
        {
            // Путь к нужному ключу реестра
            string keyPathLocation = @"SOFTWARE\Microsoft\Windows\CurrentVersion\CapabilityAccessManager\ConsentStore\userDataTasks";

            bool operationSuccessLocation = false; // Флаг успешности операции
            try
            {
                // Открытие ключа реестра HKEY_CURRENT_USER\...\location для изменения
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(keyPathLocation, true))
                {
                    if (key != null)
                    {
                        // Установка значения параметра "Value" в "Deny"
                        key.SetValue("Value", "Deny", RegistryValueKind.String);

                        operationSuccessLocation = true;
                    }
                    else
                    {
                        // Если ключ не существует, его нужно создать, и затем установить параметр
                        using (RegistryKey newKey = Registry.CurrentUser.CreateSubKey(keyPathLocation))
                        {
                            if (newKey != null)
                            {
                                newKey.SetValue("Value", "Deny", RegistryValueKind.String);

                                operationSuccessLocation = true;
                            }
                        }
                    }
                }
            }
            catch
            {
                operationSuccessLocation = false;
            }

            if (operationSuccessLocation)
            {
                // Здесь укажите логику для успешной операции, например, изменение цвета фона кнопки и отображение уведомления
                // Пример для кнопки с именем "ChangeLocationAccessButton"
                DeleteFolderButton19.Background = new SolidColorBrush(Colors.Green);
            }
            else
            {
                // Логика для неудачной операции, например, изменение цвета фона кнопки и отображение уведомления об ошибке
                DeleteFolderButton19.Background = new SolidColorBrush(Colors.Red);
            }
        }

        private void Button_Click_20(object sender, RoutedEventArgs e)
        {
            // Путь к нужному ключу реестра
            string keyPathLocation = @"SOFTWARE\Microsoft\Windows\CurrentVersion\CapabilityAccessManager\ConsentStore\chat";

            bool operationSuccessLocation = false; // Флаг успешности операции
            try
            {
                // Открытие ключа реестра HKEY_CURRENT_USER\...\location для изменения
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(keyPathLocation, true))
                {
                    if (key != null)
                    {
                        // Установка значения параметра "Value" в "Deny"
                        key.SetValue("Value", "Deny", RegistryValueKind.String);

                        operationSuccessLocation = true;
                    }
                    else
                    {
                        // Если ключ не существует, его нужно создать, и затем установить параметр
                        using (RegistryKey newKey = Registry.CurrentUser.CreateSubKey(keyPathLocation))
                        {
                            if (newKey != null)
                            {
                                newKey.SetValue("Value", "Deny", RegistryValueKind.String);

                                operationSuccessLocation = true;
                            }
                        }
                    }
                }
            }
            catch
            {
                operationSuccessLocation = false;
            }

            if (operationSuccessLocation)
            {
                // Здесь укажите логику для успешной операции, например, изменение цвета фона кнопки и отображение уведомления
                // Пример для кнопки с именем "ChangeLocationAccessButton"
                DeleteFolderButton20.Background = new SolidColorBrush(Colors.Green);
            }
            else
            {
                // Логика для неудачной операции, например, изменение цвета фона кнопки и отображение уведомления об ошибке
                DeleteFolderButton20.Background = new SolidColorBrush(Colors.Red);
            }
        }

        private void Button_Click_21(object sender, RoutedEventArgs e)
        {
            // Путь к нужному ключу реестра
            string keyPathLocation = @"SOFTWARE\Microsoft\Windows\CurrentVersion\CapabilityAccessManager\ConsentStore\radios";

            bool operationSuccessLocation = false; // Флаг успешности операции
            try
            {
                // Открытие ключа реестра HKEY_CURRENT_USER\...\location для изменения
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(keyPathLocation, true))
                {
                    if (key != null)
                    {
                        // Установка значения параметра "Value" в "Deny"
                        key.SetValue("Value", "Deny", RegistryValueKind.String);

                        operationSuccessLocation = true;
                    }
                    else
                    {
                        // Если ключ не существует, его нужно создать, и затем установить параметр
                        using (RegistryKey newKey = Registry.CurrentUser.CreateSubKey(keyPathLocation))
                        {
                            if (newKey != null)
                            {
                                newKey.SetValue("Value", "Deny", RegistryValueKind.String);

                                operationSuccessLocation = true;
                            }
                        }
                    }
                }
            }
            catch
            {
                operationSuccessLocation = false;
            }

            if (operationSuccessLocation)
            {
                // Здесь укажите логику для успешной операции, например, изменение цвета фона кнопки и отображение уведомления
                // Пример для кнопки с именем "ChangeLocationAccessButton"
                DeleteFolderButton21.Background = new SolidColorBrush(Colors.Green);
            }
            else
            {
                // Логика для неудачной операции, например, изменение цвета фона кнопки и отображение уведомления об ошибке
                DeleteFolderButton21.Background = new SolidColorBrush(Colors.Red);
            }
        }

        private void Button_Click_22(object sender, RoutedEventArgs e)
        {
            // Путь к нужному ключу реестра
            string keyPathLocation = @"SOFTWARE\Microsoft\Windows\CurrentVersion\CapabilityAccessManager\ConsentStore\appDiagnostics";

            bool operationSuccessLocation = false; // Флаг успешности операции
            try
            {
                // Открытие ключа реестра HKEY_CURRENT_USER\...\location для изменения
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(keyPathLocation, true))
                {
                    if (key != null)
                    {
                        // Установка значения параметра "Value" в "Deny"
                        key.SetValue("Value", "Deny", RegistryValueKind.String);

                        operationSuccessLocation = true;
                    }
                    else
                    {
                        // Если ключ не существует, его нужно создать, и затем установить параметр
                        using (RegistryKey newKey = Registry.CurrentUser.CreateSubKey(keyPathLocation))
                        {
                            if (newKey != null)
                            {
                                newKey.SetValue("Value", "Deny", RegistryValueKind.String);

                                operationSuccessLocation = true;
                            }
                        }
                    }
                }
            }
            catch
            {
                operationSuccessLocation = false;
            }

            if (operationSuccessLocation)
            {
                // Здесь укажите логику для успешной операции, например, изменение цвета фона кнопки и отображение уведомления
                // Пример для кнопки с именем "ChangeLocationAccessButton"
                DeleteFolderButton22.Background = new SolidColorBrush(Colors.Green);
            }
            else
            {
                // Логика для неудачной операции, например, изменение цвета фона кнопки и отображение уведомления об ошибке
                DeleteFolderButton22.Background = new SolidColorBrush(Colors.Red);
            }
        }

        private void Button_Click_23(object sender, RoutedEventArgs e)
        {
            // Путь к ключу для удаления в HKEY_CURRENT_USER
            const string currentUserKeyPath = @"Software\Policies\Microsoft\Windows\DataCollection";

            // Пытаемся удалить ключ для текущего пользователя
            using (RegistryKey currentUserKey = Registry.CurrentUser.OpenSubKey(currentUserKeyPath, writable: true))
            {
                if (currentUserKey != null)
                {
                    Registry.CurrentUser.DeleteSubKeyTree(currentUserKeyPath, false);
                    DeleteFolderButton23.Background = new SolidColorBrush(Colors.Green);
                }
            }

            // Путь и значения для установки в HKEY_LOCAL_MACHINE
            const string localMachineKeyPath = @"Software\Policies\Microsoft\Windows\DataCollection";
            Dictionary<string, int> valuesToSet = new Dictionary<string, int>
    {
        {"AllowDesktopAnalyticsProcessing", 0},
        {"LimitEnhancedDiagnosticDataWindowsAnalytics", 1},
        {"AllowTelemetry", 0},
        {"AllowDeviceNameInTelemetry", 0},
        {"DisableTelemetryOptInChangeNotification", 0},
        {"AllowWUfBCloudProcessing", 0},
        {"AllowUpdateComplianceProcessing", 0},
        {"DisableTelemetryOptInSettingsUx", 0}
    };

            // Пытаемся установить значения в HKEY_LOCAL_MACHINE
            using (RegistryKey localMachineKey = Registry.LocalMachine.CreateSubKey(localMachineKeyPath))
            {
                if (localMachineKey != null)
                {
                    foreach (var pair in valuesToSet)
                    {
                        localMachineKey.SetValue(pair.Key, pair.Value, RegistryValueKind.DWord);
                    }
                    DeleteFolderButton23.Background = new SolidColorBrush(Colors.Green);
                }
                else
                {
                    DeleteFolderButton23.Background = new SolidColorBrush(Colors.Red);
                }
            }
        }

        private void Button_Click_24(object sender, RoutedEventArgs e)
        {
            // Путь к нужному ключу реестра
            string keyPath = @"SOFTWARE\Microsoft\Windows\CurrentVersion\BackgroundAccessApplications";

            bool operationSuccess = false; // Флаг успешности операции
            try
            {
                // Открытие ключа реестра HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Themes\Personalize для изменения
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(keyPath, true))
                {
                    if (key != null)
                    {
                        // Установка значения параметра "AppsUseLightTheme" в 0
                        key.SetValue("GlobalUserDisabled", 1, RegistryValueKind.DWord);


                        operationSuccess = true;
                    }
                    else
                    {
                        // Если ключ не существует, его нужно создать, и затем создать параметры
                        using (RegistryKey newKey = Registry.CurrentUser.CreateSubKey(keyPath))
                        {
                            if (newKey != null)
                            {
                                newKey.SetValue("GlobalUserDisabled", 1, RegistryValueKind.DWord);

                            }
                        }
                    }
                }
            }
            catch
            {
                operationSuccess = false;
            }

            if (operationSuccess)
            {
                DeleteFolderButton24.Background = new SolidColorBrush(Colors.Green);
            }
            else
            {
                DeleteFolderButton24.Background = new SolidColorBrush(Colors.Red);
            }
        }

        private void Button_Click_25(object sender, RoutedEventArgs e)
        {
            bool operationSuccess = true; // Предполагаем, что все операции будут успешными

            // Локальная функция для установки значения параметра в реестре
            void SetRegistryValue(RegistryKey root, string subKeyPath, string valueName, object valueData)
            {
                using (RegistryKey subKey = root.CreateSubKey(subKeyPath))
                {
                    if (subKey != null)
                    {
                        subKey.SetValue(valueName, valueData, RegistryValueKind.DWord);
                    }
                    else
                    {
                        throw new Exception("Failed to create or open the registry key.");
                    }
                }
            }

            try
            {
                // Создание или обновление параметра Enabled в AdvertisingInfo
                SetRegistryValue(Registry.CurrentUser, @"SOFTWARE\Microsoft\Windows\CurrentVersion\AdvertisingInfo", "Enabled", 0);

                // Создание или обновление параметра HttpAcceptLanguageOptOut в International\User Profile
                SetRegistryValue(Registry.CurrentUser, @"Control Panel\International\User Profile", "HttpAcceptLanguageOptOut", 1);

                // Создание или обновление параметра Start_TrackProgs в Explorer\Advanced
                SetRegistryValue(Registry.CurrentUser, @"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "Start_TrackProgs", 0);
            }
            catch (Exception)
            {
                operationSuccess = false;
            }

            // Обработка результата операции
            if (operationSuccess)
            {
                // Предполагаем, что DeleteFolderButton25 - это имя кнопки в вашем интерфейсе
                DeleteFolderButton25.Background = new SolidColorBrush(Colors.Green);
            }
            else
            {
                DeleteFolderButton25.Background = new SolidColorBrush(Colors.Red);
            }
        }

        private void Button_Click_26(object sender, RoutedEventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo()
            {
                FileName = "powershell.exe",
                Arguments = "powercfg /s SCHEME_MIN",
                UseShellExecute = false,
                CreateNoWindow = true, // Не создавать окно для процесса
                WindowStyle = ProcessWindowStyle.Hidden // Скрыть окно процесса
            };

            bool operationSuccess = false; // Предполагаем, что операция неуспешна

            try
            {
                using (Process process = Process.Start(startInfo))
                {
                    process.WaitForExit(); // Ожидание завершения процесса
                    if (process.ExitCode == 0) // Проверка кода возврата процесса
                    {
                        operationSuccess = true; // Операция успешна
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to execute command: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                operationSuccess = false;
            }

            // Логика для обработки результата операции
            if (operationSuccess)
            {
                // Успешное выполнение операции
                DeleteFolderButton26.Background = new SolidColorBrush(Colors.Green);
            }
            else
            {
                // Неуспешное выполнение операции
                DeleteFolderButton26.Background = new SolidColorBrush(Colors.Red);
            }
        }

        private void Button_Click_28(object sender, RoutedEventArgs e)
        {
            const string keyPath = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced";
            const string valueName = "LaunchTo";
            const int newValue = 1; // Установить "Этот компьютер" как стартовую папку
            bool operationSuccess = false;

            try
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(keyPath, true))
                {
                    if (key != null)
                    {
                        key.SetValue(valueName, newValue, RegistryValueKind.DWord);
                        operationSuccess = true;
                    }
                }
            }
            catch (Exception)
            {
            }

            // Обновление UI в зависимости от результата операции
            if (operationSuccess)
            {
                // Здесь укажите логику для успешной операции, например, изменение цвета фона кнопки и отображение уведомления
                // Пример для кнопки с именем "ChangeLaunchToButton"
                DeleteFolderButton28.Background = new SolidColorBrush(Colors.Green);
            }
            else
            {
                // Логика для неудачной операции, например, изменение цвета фона кнопки и отображение уведомления об ошибке
                DeleteFolderButton28.Background = new SolidColorBrush(Colors.Red);
            }
        }

        private void Button_Click_29(object sender, RoutedEventArgs e)
        {
            // Путь к нужному ключу реестра
            string keyPath = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced";

            bool operationSuccess = false; // Флаг успешности операции
            try
            {
                // Открытие ключа реестра HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Themes\Personalize для изменения
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(keyPath, true))
                {
                    if (key != null)
                    {
                        // Установка значения параметра "AppsUseLightTheme" в 0
                        key.SetValue("JointResize", 0, RegistryValueKind.DWord);
                        // Установка значения параметра "AppsUseLightTheme" в 0
                        key.SetValue("SnapFill", 0, RegistryValueKind.DWord);
                        // Установка значения параметра "AppsUseLightTheme" в 0
                        key.SetValue("SnapAssist", 0, RegistryValueKind.DWord);

                        operationSuccess = true;
                    }
                    else
                    {

                        using (RegistryKey newKey = Registry.CurrentUser.CreateSubKey(keyPath))
                        {
                            if (newKey != null) // Если ключ не существует, его нужно создать, и затем создать параметры
                            {
                                newKey.SetValue("JointResize", 0, RegistryValueKind.DWord);
                                newKey.SetValue("SnapFill", 0, RegistryValueKind.DWord);
                                newKey.SetValue("SnapAssist", 0, RegistryValueKind.DWord);

                            }
                        }
                    }
                }
            }
            catch
            {
                operationSuccess = false;
            }

            if (operationSuccess)
            {
                DeleteFolderButton29.Background = new SolidColorBrush(Colors.Green);
            }
            else
            {
                DeleteFolderButton29.Background = new SolidColorBrush(Colors.Red);
            }
        }

        private void Button_Click_30(object sender, RoutedEventArgs e)
        {

            const string keyPath = @"SOFTWARE\Spotify";
            bool keyExists = false;

            try
            {
                // Проверка существования ключа
                using (var key = Registry.CurrentUser.OpenSubKey(keyPath))
                {
                    if (key != null)
                    {
                        keyExists = true;
                        // Ключ существует, закрываем и переходим к его удалению
                    }
                }

                if (!keyExists)
                {
                    // Если ключ не найден, выбрасываем исключение
                    throw new InvalidOperationException("Spotify registry key does not exist.");
                }

                // Удаление ключа, если он существует
                Registry.CurrentUser.DeleteSubKey(keyPath, false);
                DeleteFolderButton30.Background = new SolidColorBrush(Colors.Green);
            }
            catch (InvalidOperationException)
            {
                // Обработка случая, когда ключ не существует
                DeleteFolderButton30.Background = new SolidColorBrush(Colors.Green);
            }
            catch (Exception)
            {
                // Обработка других видов исключений
                DeleteFolderButton30.Background = new SolidColorBrush(Colors.Red);
            }

        }

        private void Button_Click_31(object sender, RoutedEventArgs e)
        {
            const string keyPath = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer";
            try
            {
                // Открываем ключ реестра HKEY_LOCAL_MACHINE с возможностью записи.
                using (var key = Registry.LocalMachine.OpenSubKey(keyPath, writable: true))
                {
                    if (key != null)
                    {
                        // Создаем или обновляем параметр HubMode со значением 1.
                        key.SetValue("HubMode", 1, RegistryValueKind.DWord);
                        DeleteFolderButton31.Background = new SolidColorBrush(Colors.Green);
                    }
                    else
                    {
                        DeleteFolderButton31.Background = new SolidColorBrush(Colors.Red);
                    }
                }
            }
            catch (Exception)
            {
                DeleteFolderButton31.Background = new SolidColorBrush(Colors.Red);
            }

            const string baseKeyPath = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Desktop\NameSpace_36354489";
            const string subKeyToDelete = "{f874310e-b6b7-47dc-bc84-b9e6b38f5903}";
            try
            {
                using (var baseKey = Registry.LocalMachine.OpenSubKey(baseKeyPath, writable: true))
                {
                    if (baseKey != null && baseKey.GetSubKeyNames().Contains(subKeyToDelete))
                    {
                        baseKey.DeleteSubKey(subKeyToDelete);
                    }
                    else
                    {
                    }
                }
            }
            catch (Exception)
            {
            }
        }
       
        private void Button_Click_33(object sender, RoutedEventArgs e)
        {
            // Путь к ключу в HKEY_LOCAL_MACHINE
            const string keyPath = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\DataCollection";

            try
            {
                // Открываем ключ реестра HKEY_LOCAL_MACHINE с возможностью записи
                using (RegistryKey key = Registry.LocalMachine.CreateSubKey(keyPath))
                {
                    if (key != null)
                    {
                        // Устанавливаем значения параметров
                        key.SetValue("AllowTelemetry", 3, RegistryValueKind.DWord);
                        key.SetValue("MaxTelemetryAllowed", 3, RegistryValueKind.DWord);
                        DeleteFolderButton33.Background = new SolidColorBrush(Colors.Green);
                    }
                    else
                    {
                        DeleteFolderButton33.Background = new SolidColorBrush(Colors.Red);
                    }
                }
            }
            catch (Exception)
            {
                DeleteFolderButton33.Background = new SolidColorBrush(Colors.Red);
            }
        }

        private void Button_Click_34(object sender, RoutedEventArgs e)
        {
            // Устанавливаем значение ключа в HKEY_CLASSES_ROOT
            const string clsidKeyPath = @"CLSID\{0E270DAA-1BE6-48F2-AC49-AA5080D95EBC}";
            try
            {
                using (RegistryKey clsidKey = Registry.ClassesRoot.CreateSubKey(clsidKeyPath))
                {
                    if (clsidKey != null)
                    {
                        clsidKey.SetValue("System.IsPinnedToNameSpaceTree", 0, RegistryValueKind.DWord);
                        DeleteFolderButton34.Background = new SolidColorBrush(Colors.Green);
                    }
                    else
                    {
                        DeleteFolderButton34.Background = new SolidColorBrush(Colors.Red);
                    }
                }
            }
            catch (Exception)
            {
                DeleteFolderButton34.Background = new SolidColorBrush(Colors.Red);
            }
        }


















        private async void Button_Click_32(object sender, RoutedEventArgs e)
        {
            Button_Click_1(sender, e);
            await Task.Delay(100); // небольшая задержка для имитации асинхронности

            Button_Click_2(sender, e);
            await Task.Delay(100); // небольшая задержка для имитации асинхронности

            Button_Click_3(sender, e);
            await Task.Delay(100); // небольшая задержка для имитации асинхронности

            Button_Click_5(sender, e);
            await Task.Delay(100); // небольшая задержка для имитации асинхронности

            Button_Click_6(sender, e);
            await Task.Delay(100); // небольшая задержка для имитации асинхронности

            Button_Click_7(sender, e);
            await Task.Delay(100); // небольшая задержка для имитации асинхронности

            Button_Click_8(sender, e);
            await Task.Delay(100); // небольшая задержка для имитации асинхронности

            Button_Click_9(sender, e);
            await Task.Delay(100); // небольшая задержка для имитации асинхронности

            Button_Click_10(sender, e);
            await Task.Delay(100); // небольшая задержка для имитации асинхронности

            Button_Click_11(sender, e);
            await Task.Delay(100); // небольшая задержка для имитации асинхронности

            Button_Click_12(sender, e);
            await Task.Delay(100); // небольшая задержка для имитации асинхронности

            Button_Click_13(sender, e);
            await Task.Delay(100); // небольшая задержка для имитации асинхронности

            Button_Click_14(sender, e);
            await Task.Delay(100); // небольшая задержка для имитации асинхронности

            Button_Click_15(sender, e);
            await Task.Delay(100); // небольшая задержка для имитации асинхронности

            Button_Click_16(sender, e);
            await Task.Delay(100); // небольшая задержка для имитации асинхронности

            Button_Click_17(sender, e);
            await Task.Delay(100); // небольшая задержка для имитации асинхронности

            Button_Click_18(sender, e);
            await Task.Delay(100); // небольшая задержка для имитации асинхронности

            Button_Click_19(sender, e);
            await Task.Delay(100); // небольшая задержка для имитации асинхронности

            Button_Click_20(sender, e);
            await Task.Delay(100); // небольшая задержка для имитации асинхронности

            Button_Click_21(sender, e);
            await Task.Delay(100); // небольшая задержка для имитации асинхронности

            Button_Click_22(sender, e);
            await Task.Delay(100); // небольшая задержка для имитации асинхронности

            Button_Click_23(sender, e);
            await Task.Delay(100); // небольшая задержка для имитации асинхронности

            Button_Click_24(sender, e);
            await Task.Delay(100); // небольшая задержка для имитации асинхронности

            Button_Click_25(sender, e);
            await Task.Delay(100); // небольшая задержка для имитации асинхронности

            Button_Click_26(sender, e);
            await Task.Delay(100); // небольшая задержка для имитации асинхронности

            Button_Click_28(sender, e);
            await Task.Delay(100); // небольшая задержка для имитации асинхронности

            Button_Click_29(sender, e);
            await Task.Delay(100); // небольшая задержка для имитации асинхронности

            Button_Click_30(sender, e);
            await Task.Delay(100); // небольшая задержка для имитации асинхронности

            Button_Click_31(sender, e);
            await Task.Delay(100); // небольшая задержка для имитации асинхронности

            Button_Click_33(sender, e);
            await Task.Delay(100); // небольшая задержка для имитации асинхронности

            Button_Click_34(sender, e);
            await Task.Delay(100); // небольшая задержка для имитации асинхронности


            DeleteFolderButton32.Background = new SolidColorBrush(Colors.Green); // ----------------------------------------------
           
        }

       
    }
}
