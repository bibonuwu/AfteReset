using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WPFUIKitProfessional.Pages
{
    /// <summary>
    /// Lógica de interacción para Messages.xaml
    /// </summary>
    public partial class Messages : Page
    {
        public Messages()
        {
            InitializeComponent();
        }







        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string packageName = "Microsoft.BingWeather"; // ------------------------------------------------------------------------------
            string checkCommand = $"Get-AppxPackage -Name {packageName}";
            string removeCommand = $"Get-AppxPackage -Name {packageName} | Remove-AppxPackage";

            ProcessStartInfo startInfoCheck = new ProcessStartInfo
            {
                FileName = "powershell.exe",
                Arguments = $"-NoProfile -ExecutionPolicy Bypass -Command \"{checkCommand}\"",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = true
            };

            try
            {
                // Проверка наличия
                using (Process processCheck = Process.Start(startInfoCheck))
                {
                    string output = processCheck.StandardOutput.ReadToEnd();
                    processCheck.WaitForExit();

                    if (string.IsNullOrWhiteSpace(output))
                    {
                        // Не найден
                        DeleteFolderButton1.Background = new SolidColorBrush(Colors.Green); // ----------------------------------------------
                    }
                    else
                    {
                        // Найден, попытка удаления
                        ProcessStartInfo startInfoRemove = new ProcessStartInfo
                        {
                            FileName = "powershell.exe",
                            Arguments = $"-NoProfile -ExecutionPolicy Bypass -Command \"{removeCommand}\"",
                            UseShellExecute = false,
                            RedirectStandardOutput = true,
                            CreateNoWindow = true
                        };

                        using (Process processRemove = Process.Start(startInfoRemove))
                        {
                            processRemove.WaitForExit();
                            if (processRemove.ExitCode == 0)
                            {
                                // Skype успешно удален
                                DeleteFolderButton1.Background = new SolidColorBrush(Colors.Green); // -------------------------------------
                            }
                            else
                            {
                                // Ошибка при удалении Skype
                                DeleteFolderButton1.Background = new SolidColorBrush(Colors.Red); // ---------------------------------------
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                DeleteFolderButton1.Background = new SolidColorBrush(Colors.Red);
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string packageName = "Microsoft.GetHelp"; // ------------------------------------------------------------------------------
            string checkCommand = $"Get-AppxPackage -Name {packageName}";
            string removeCommand = $"Get-AppxPackage -Name {packageName} | Remove-AppxPackage";

            ProcessStartInfo startInfoCheck = new ProcessStartInfo
            {
                FileName = "powershell.exe",
                Arguments = $"-NoProfile -ExecutionPolicy Bypass -Command \"{checkCommand}\"",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = true
            };
            try
            {
                // Проверка наличия
                using (Process processCheck = Process.Start(startInfoCheck))
                {
                    string output = processCheck.StandardOutput.ReadToEnd();
                    processCheck.WaitForExit();

                    if (string.IsNullOrWhiteSpace(output))
                    {
                        // Не найден
                        DeleteFolderButton2.Background = new SolidColorBrush(Colors.Green); // ----------------------------------------------
                    }
                    else
                    {
                        // Найден, попытка удаления
                        ProcessStartInfo startInfoRemove = new ProcessStartInfo
                        {
                            FileName = "powershell.exe",
                            Arguments = $"-NoProfile -ExecutionPolicy Bypass -Command \"{removeCommand}\"",
                            UseShellExecute = false,
                            RedirectStandardOutput = true,
                            CreateNoWindow = true
                        };

                        using (Process processRemove = Process.Start(startInfoRemove))
                        {
                            processRemove.WaitForExit();
                            if (processRemove.ExitCode == 0)
                            {
                                // Skype успешно удален
                                DeleteFolderButton2.Background = new SolidColorBrush(Colors.Green); // -------------------------------------
                            }
                            else
                            {
                                // Ошибка при удалении Skype
                                DeleteFolderButton2.Background = new SolidColorBrush(Colors.Red); // ---------------------------------------
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                DeleteFolderButton2.Background = new SolidColorBrush(Colors.Red);
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            string packageName = "Microsoft.Microsoft3DViewer"; // ------------------------------------------------------------------------------
            string checkCommand = $"Get-AppxPackage -Name {packageName}";
            string removeCommand = $"Get-AppxPackage -Name {packageName} | Remove-AppxPackage";

            ProcessStartInfo startInfoCheck = new ProcessStartInfo
            {
                FileName = "powershell.exe",
                Arguments = $"-NoProfile -ExecutionPolicy Bypass -Command \"{checkCommand}\"",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = true
            };

            try
            {
                // Проверка наличия
                using (Process processCheck = Process.Start(startInfoCheck))
                {
                    string output = processCheck.StandardOutput.ReadToEnd();
                    processCheck.WaitForExit();

                    if (string.IsNullOrWhiteSpace(output))
                    {
                        // Не найден
                        DeleteFolderButton3.Background = new SolidColorBrush(Colors.Green); // ----------------------------------------------
                    }
                    else
                    {
                        // Найден, попытка удаления
                        ProcessStartInfo startInfoRemove = new ProcessStartInfo
                        {
                            FileName = "powershell.exe",
                            Arguments = $"-NoProfile -ExecutionPolicy Bypass -Command \"{removeCommand}\"",
                            UseShellExecute = false,
                            RedirectStandardOutput = true,
                            CreateNoWindow = true
                        };

                        using (Process processRemove = Process.Start(startInfoRemove))
                        {
                            processRemove.WaitForExit();
                            if (processRemove.ExitCode == 0)
                            {
                                // Skype успешно удален
                                DeleteFolderButton3.Background = new SolidColorBrush(Colors.Green); // -------------------------------------
                            }
                            else
                            {
                                // Ошибка при удалении Skype
                                DeleteFolderButton3.Background = new SolidColorBrush(Colors.Red); // ---------------------------------------
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                DeleteFolderButton3.Background = new SolidColorBrush(Colors.Red);
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            string packageName = "Microsoft.MicrosoftOfficeHub"; // ------------------------------------------------------------------------------
            string checkCommand = $"Get-AppxPackage -Name {packageName}";
            string removeCommand = $"Get-AppxPackage -Name {packageName} | Remove-AppxPackage";

            ProcessStartInfo startInfoCheck = new ProcessStartInfo
            {
                FileName = "powershell.exe",
                Arguments = $"-NoProfile -ExecutionPolicy Bypass -Command \"{checkCommand}\"",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = true
            };

            try
            {
                // Проверка наличия
                using (Process processCheck = Process.Start(startInfoCheck))
                {
                    string output = processCheck.StandardOutput.ReadToEnd();
                    processCheck.WaitForExit();

                    if (string.IsNullOrWhiteSpace(output))
                    {
                        // Не найден
                        DeleteFolderButton4.Background = new SolidColorBrush(Colors.Green); // ----------------------------------------------
                    }
                    else
                    {
                        // Найден, попытка удаления
                        ProcessStartInfo startInfoRemove = new ProcessStartInfo
                        {
                            FileName = "powershell.exe",
                            Arguments = $"-NoProfile -ExecutionPolicy Bypass -Command \"{removeCommand}\"",
                            UseShellExecute = false,
                            RedirectStandardOutput = true,
                            CreateNoWindow = true
                        };

                        using (Process processRemove = Process.Start(startInfoRemove))
                        {
                            processRemove.WaitForExit();
                            if (processRemove.ExitCode == 0)
                            {
                                // Skype успешно удален
                                DeleteFolderButton4.Background = new SolidColorBrush(Colors.Green); // -------------------------------------
                            }
                            else
                            {
                                // Ошибка при удалении Skype
                                DeleteFolderButton4.Background = new SolidColorBrush(Colors.Red); // ---------------------------------------
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                DeleteFolderButton4.Background = new SolidColorBrush(Colors.Red);
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            string packageName = "Microsoft.MicrosoftStickyNotes"; // ------------------------------------------------------------------------------
            string checkCommand = $"Get-AppxPackage -Name {packageName}";
            string removeCommand = $"Get-AppxPackage -Name {packageName} | Remove-AppxPackage";

            ProcessStartInfo startInfoCheck = new ProcessStartInfo
            {
                FileName = "powershell.exe",
                Arguments = $"-NoProfile -ExecutionPolicy Bypass -Command \"{checkCommand}\"",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = true
            };

            try
            {
                // Проверка наличия
                using (Process processCheck = Process.Start(startInfoCheck))
                {
                    string output = processCheck.StandardOutput.ReadToEnd();
                    processCheck.WaitForExit();

                    if (string.IsNullOrWhiteSpace(output))
                    {
                        // Не найден
                        DeleteFolderButton5.Background = new SolidColorBrush(Colors.Green); // ----------------------------------------------
                    }
                    else
                    {
                        // Найден, попытка удаления
                        ProcessStartInfo startInfoRemove = new ProcessStartInfo
                        {
                            FileName = "powershell.exe",
                            Arguments = $"-NoProfile -ExecutionPolicy Bypass -Command \"{removeCommand}\"",
                            UseShellExecute = false,
                            RedirectStandardOutput = true,
                            CreateNoWindow = true
                        };

                        using (Process processRemove = Process.Start(startInfoRemove))
                        {
                            processRemove.WaitForExit();
                            if (processRemove.ExitCode == 0)
                            {
                                // Skype успешно удален
                                DeleteFolderButton5.Background = new SolidColorBrush(Colors.Green); // -------------------------------------
                            }
                            else
                            {
                                // Ошибка при удалении Skype
                                DeleteFolderButton5.Background = new SolidColorBrush(Colors.Red); // ---------------------------------------
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                DeleteFolderButton5.Background = new SolidColorBrush(Colors.Red);
            }
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            string packageName = "Microsoft.Office.OneNote"; // ------------------------------------------------------------------------------
            string checkCommand = $"Get-AppxPackage -Name {packageName}";
            string removeCommand = $"Get-AppxPackage -Name {packageName} | Remove-AppxPackage";

            ProcessStartInfo startInfoCheck = new ProcessStartInfo
            {
                FileName = "powershell.exe",
                Arguments = $"-NoProfile -ExecutionPolicy Bypass -Command \"{checkCommand}\"",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = true
            };

            try
            {
                // Проверка наличия
                using (Process processCheck = Process.Start(startInfoCheck))
                {
                    string output = processCheck.StandardOutput.ReadToEnd();
                    processCheck.WaitForExit();

                    if (string.IsNullOrWhiteSpace(output))
                    {
                        // Не найден
                        DeleteFolderButton6.Background = new SolidColorBrush(Colors.Green); // ----------------------------------------------
                    }
                    else
                    {
                        // Найден, попытка удаления
                        ProcessStartInfo startInfoRemove = new ProcessStartInfo
                        {
                            FileName = "powershell.exe",
                            Arguments = $"-NoProfile -ExecutionPolicy Bypass -Command \"{removeCommand}\"",
                            UseShellExecute = false,
                            RedirectStandardOutput = true,
                            CreateNoWindow = true
                        };

                        using (Process processRemove = Process.Start(startInfoRemove))
                        {
                            processRemove.WaitForExit();
                            if (processRemove.ExitCode == 0)
                            {
                                // Skype успешно удален
                                DeleteFolderButton6.Background = new SolidColorBrush(Colors.Green); // -------------------------------------
                            }
                            else
                            {
                                // Ошибка при удалении Skype
                                DeleteFolderButton6.Background = new SolidColorBrush(Colors.Red); // ---------------------------------------
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                DeleteFolderButton6.Background = new SolidColorBrush(Colors.Red);
            }
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            string packageName = "Microsoft.People"; // ------------------------------------------------------------------------------
            string checkCommand = $"Get-AppxPackage -Name {packageName}";
            string removeCommand = $"Get-AppxPackage -Name {packageName} | Remove-AppxPackage";

            ProcessStartInfo startInfoCheck = new ProcessStartInfo
            {
                FileName = "powershell.exe",
                Arguments = $"-NoProfile -ExecutionPolicy Bypass -Command \"{checkCommand}\"",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = true
            };

            try
            {
                // Проверка наличия
                using (Process processCheck = Process.Start(startInfoCheck))
                {
                    string output = processCheck.StandardOutput.ReadToEnd();
                    processCheck.WaitForExit();

                    if (string.IsNullOrWhiteSpace(output))
                    {
                        // Не найден
                        DeleteFolderButton7.Background = new SolidColorBrush(Colors.Green); // ----------------------------------------------
                    }
                    else
                    {
                        // Найден, попытка удаления
                        ProcessStartInfo startInfoRemove = new ProcessStartInfo
                        {
                            FileName = "powershell.exe",
                            Arguments = $"-NoProfile -ExecutionPolicy Bypass -Command \"{removeCommand}\"",
                            UseShellExecute = false,
                            RedirectStandardOutput = true,
                            CreateNoWindow = true
                        };

                        using (Process processRemove = Process.Start(startInfoRemove))
                        {
                            processRemove.WaitForExit();
                            if (processRemove.ExitCode == 0)
                            {
                                // Skype успешно удален
                                DeleteFolderButton7.Background = new SolidColorBrush(Colors.Green); // -------------------------------------
                            }
                            else
                            {
                                // Ошибка при удалении Skype
                                DeleteFolderButton7.Background = new SolidColorBrush(Colors.Red); // ---------------------------------------
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                DeleteFolderButton7.Background = new SolidColorBrush(Colors.Red);
            }
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            string packageName = "Microsoft.ScreenSketch"; // ------------------------------------------------------------------------------
            string checkCommand = $"Get-AppxPackage -Name {packageName}";
            string removeCommand = $"Get-AppxPackage -Name {packageName} | Remove-AppxPackage";

            ProcessStartInfo startInfoCheck = new ProcessStartInfo
            {
                FileName = "powershell.exe",
                Arguments = $"-NoProfile -ExecutionPolicy Bypass -Command \"{checkCommand}\"",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = true
            };

            try
            {
                // Проверка наличия
                using (Process processCheck = Process.Start(startInfoCheck))
                {
                    string output = processCheck.StandardOutput.ReadToEnd();
                    processCheck.WaitForExit();

                    if (string.IsNullOrWhiteSpace(output))
                    {
                        // Не найден
                        DeleteFolderButton8.Background = new SolidColorBrush(Colors.Green); // ----------------------------------------------
                    }
                    else
                    {
                        // Найден, попытка удаления
                        ProcessStartInfo startInfoRemove = new ProcessStartInfo
                        {
                            FileName = "powershell.exe",
                            Arguments = $"-NoProfile -ExecutionPolicy Bypass -Command \"{removeCommand}\"",
                            UseShellExecute = false,
                            RedirectStandardOutput = true,
                            CreateNoWindow = true
                        };

                        using (Process processRemove = Process.Start(startInfoRemove))
                        {
                            processRemove.WaitForExit();
                            if (processRemove.ExitCode == 0)
                            {
                                // Skype успешно удален
                                DeleteFolderButton8.Background = new SolidColorBrush(Colors.Green); // -------------------------------------
                            }
                            else
                            {
                                // Ошибка при удалении Skype
                                DeleteFolderButton8.Background = new SolidColorBrush(Colors.Red); // ---------------------------------------
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                DeleteFolderButton8.Background = new SolidColorBrush(Colors.Red);
            }
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            string packageName = "Microsoft.Wallet"; // ------------------------------------------------------------------------------
            string checkCommand = $"Get-AppxPackage -Name {packageName}";
            string removeCommand = $"Get-AppxPackage -Name {packageName} | Remove-AppxPackage";

            ProcessStartInfo startInfoCheck = new ProcessStartInfo
            {
                FileName = "powershell.exe",
                Arguments = $"-NoProfile -ExecutionPolicy Bypass -Command \"{checkCommand}\"",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = true
            };

            try
            {
                // Проверка наличия
                using (Process processCheck = Process.Start(startInfoCheck))
                {
                    string output = processCheck.StandardOutput.ReadToEnd();
                    processCheck.WaitForExit();

                    if (string.IsNullOrWhiteSpace(output))
                    {
                        // Не найден
                        DeleteFolderButton9.Background = new SolidColorBrush(Colors.Green); // ----------------------------------------------
                    }
                    else
                    {
                        // Найден, попытка удаления
                        ProcessStartInfo startInfoRemove = new ProcessStartInfo
                        {
                            FileName = "powershell.exe",
                            Arguments = $"-NoProfile -ExecutionPolicy Bypass -Command \"{removeCommand}\"",
                            UseShellExecute = false,
                            RedirectStandardOutput = true,
                            CreateNoWindow = true
                        };

                        using (Process processRemove = Process.Start(startInfoRemove))
                        {
                            processRemove.WaitForExit();
                            if (processRemove.ExitCode == 0)
                            {
                                // Skype успешно удален
                                DeleteFolderButton9.Background = new SolidColorBrush(Colors.Green); // -------------------------------------
                            }
                            else
                            {
                                // Ошибка при удалении Skype
                                DeleteFolderButton9.Background = new SolidColorBrush(Colors.Red); // ---------------------------------------
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                DeleteFolderButton9.Background = new SolidColorBrush(Colors.Red);
            }
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            string packageName = "Microsoft.WindowsFeedbackHub"; // ------------------------------------------------------------------------------
            string checkCommand = $"Get-AppxPackage -Name {packageName}";
            string removeCommand = $"Get-AppxPackage -Name {packageName} | Remove-AppxPackage";

            ProcessStartInfo startInfoCheck = new ProcessStartInfo
            {
                FileName = "powershell.exe",
                Arguments = $"-NoProfile -ExecutionPolicy Bypass -Command \"{checkCommand}\"",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = true
            };

            try
            {
                // Проверка наличия
                using (Process processCheck = Process.Start(startInfoCheck))
                {
                    string output = processCheck.StandardOutput.ReadToEnd();
                    processCheck.WaitForExit();

                    if (string.IsNullOrWhiteSpace(output))
                    {
                        // Не найден
                        DeleteFolderButton10.Background = new SolidColorBrush(Colors.Green); // ----------------------------------------------
                    }
                    else
                    {
                        // Найден, попытка удаления
                        ProcessStartInfo startInfoRemove = new ProcessStartInfo
                        {
                            FileName = "powershell.exe",
                            Arguments = $"-NoProfile -ExecutionPolicy Bypass -Command \"{removeCommand}\"",
                            UseShellExecute = false,
                            RedirectStandardOutput = true,
                            CreateNoWindow = true
                        };

                        using (Process processRemove = Process.Start(startInfoRemove))
                        {
                            processRemove.WaitForExit();
                            if (processRemove.ExitCode == 0)
                            {
                                // Skype успешно удален
                                DeleteFolderButton10.Background = new SolidColorBrush(Colors.Green); // -------------------------------------
                            }
                            else
                            {
                                // Ошибка при удалении Skype
                                DeleteFolderButton10.Background = new SolidColorBrush(Colors.Red); // ---------------------------------------
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                DeleteFolderButton10.Background = new SolidColorBrush(Colors.Red);
            }
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            string packageName = "Microsoft.WindowsMaps"; // ------------------------------------------------------------------------------
            string checkCommand = $"Get-AppxPackage -Name {packageName}";
            string removeCommand = $"Get-AppxPackage -Name {packageName} | Remove-AppxPackage";

            ProcessStartInfo startInfoCheck = new ProcessStartInfo
            {
                FileName = "powershell.exe",
                Arguments = $"-NoProfile -ExecutionPolicy Bypass -Command \"{checkCommand}\"",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = true
            };

            try
            {
                // Проверка наличия
                using (Process processCheck = Process.Start(startInfoCheck))
                {
                    string output = processCheck.StandardOutput.ReadToEnd();
                    processCheck.WaitForExit();

                    if (string.IsNullOrWhiteSpace(output))
                    {
                        // Не найден
                        DeleteFolderButton11.Background = new SolidColorBrush(Colors.Green); // ----------------------------------------------
                    }
                    else
                    {
                        // Найден, попытка удаления
                        ProcessStartInfo startInfoRemove = new ProcessStartInfo
                        {
                            FileName = "powershell.exe",
                            Arguments = $"-NoProfile -ExecutionPolicy Bypass -Command \"{removeCommand}\"",
                            UseShellExecute = false,
                            RedirectStandardOutput = true,
                            CreateNoWindow = true
                        };

                        using (Process processRemove = Process.Start(startInfoRemove))
                        {
                            processRemove.WaitForExit();
                            if (processRemove.ExitCode == 0)
                            {
                                // Skype успешно удален
                                DeleteFolderButton11.Background = new SolidColorBrush(Colors.Green); // -------------------------------------
                            }
                            else
                            {
                                // Ошибка при удалении Skype
                                DeleteFolderButton11.Background = new SolidColorBrush(Colors.Red); // ---------------------------------------
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                DeleteFolderButton11.Background = new SolidColorBrush(Colors.Red);
            }
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            string packageName = "Microsoft.YourPhone"; // ------------------------------------------------------------------------------
            string checkCommand = $"Get-AppxPackage -Name {packageName}";
            string removeCommand = $"Get-AppxPackage -Name {packageName} | Remove-AppxPackage";

            ProcessStartInfo startInfoCheck = new ProcessStartInfo
            {
                FileName = "powershell.exe",
                Arguments = $"-NoProfile -ExecutionPolicy Bypass -Command \"{checkCommand}\"",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = true
            };

            try
            {
                // Проверка наличия
                using (Process processCheck = Process.Start(startInfoCheck))
                {
                    string output = processCheck.StandardOutput.ReadToEnd();
                    processCheck.WaitForExit();

                    if (string.IsNullOrWhiteSpace(output))
                    {
                        // Не найден
                        DeleteFolderButton12.Background = new SolidColorBrush(Colors.Green); // ----------------------------------------------
                    }
                    else
                    {
                        // Найден, попытка удаления
                        ProcessStartInfo startInfoRemove = new ProcessStartInfo
                        {
                            FileName = "powershell.exe",
                            Arguments = $"-NoProfile -ExecutionPolicy Bypass -Command \"{removeCommand}\"",
                            UseShellExecute = false,
                            RedirectStandardOutput = true,
                            CreateNoWindow = true
                        };

                        using (Process processRemove = Process.Start(startInfoRemove))
                        {
                            processRemove.WaitForExit();
                            if (processRemove.ExitCode == 0)
                            {
                                // Skype успешно удален
                                DeleteFolderButton12.Background = new SolidColorBrush(Colors.Green); // -------------------------------------
                            }
                            else
                            {
                                // Ошибка при удалении Skype
                                DeleteFolderButton12.Background = new SolidColorBrush(Colors.Red); // ---------------------------------------
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                DeleteFolderButton12.Background = new SolidColorBrush(Colors.Red);
            }
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            string packageName = "Microsoft.SkypeApp"; // ------------------------------------------------------------------------------
            string checkCommand = $"Get-AppxPackage -Name {packageName}";
            string removeCommand = $"Get-AppxPackage -Name {packageName} | Remove-AppxPackage";

            ProcessStartInfo startInfoCheck = new ProcessStartInfo
            {
                FileName = "powershell.exe",
                Arguments = $"-NoProfile -ExecutionPolicy Bypass -Command \"{checkCommand}\"",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = true
            };

            try
            {
                // Проверка наличия
                using (Process processCheck = Process.Start(startInfoCheck))
                {
                    string output = processCheck.StandardOutput.ReadToEnd();
                    processCheck.WaitForExit();

                    if (string.IsNullOrWhiteSpace(output))
                    {
                        // Не найден
                        DeleteFolderButton13.Background = new SolidColorBrush(Colors.Green); // ----------------------------------------------
                    }
                    else
                    {
                        // Найден, попытка удаления
                        ProcessStartInfo startInfoRemove = new ProcessStartInfo
                        {
                            FileName = "powershell.exe",
                            Arguments = $"-NoProfile -ExecutionPolicy Bypass -Command \"{removeCommand}\"",
                            UseShellExecute = false,
                            RedirectStandardOutput = true,
                            CreateNoWindow = true
                        };

                        using (Process processRemove = Process.Start(startInfoRemove))
                        {
                            processRemove.WaitForExit();
                            if (processRemove.ExitCode == 0)
                            {
                                // Skype успешно удален
                                DeleteFolderButton13.Background = new SolidColorBrush(Colors.Green); // -------------------------------------
                            }
                            else
                            {
                                // Ошибка при удалении Skype
                                DeleteFolderButton13.Background = new SolidColorBrush(Colors.Red); // ---------------------------------------
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                DeleteFolderButton13.Background = new SolidColorBrush(Colors.Red);
            }
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            string packageName = "microsoft.windowscommunicationsapps"; // ------------------------------------------------------------------------------
            string checkCommand = $"Get-AppxPackage -Name {packageName}";
            string removeCommand = $"Get-AppxPackage -Name {packageName} | Remove-AppxPackage";

            ProcessStartInfo startInfoCheck = new ProcessStartInfo
            {
                FileName = "powershell.exe",
                Arguments = $"-NoProfile -ExecutionPolicy Bypass -Command \"{checkCommand}\"",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = true
            };

            try
            {
                // Проверка наличия
                using (Process processCheck = Process.Start(startInfoCheck))
                {
                    string output = processCheck.StandardOutput.ReadToEnd();
                    processCheck.WaitForExit();

                    if (string.IsNullOrWhiteSpace(output))
                    {
                        // Не найден
                        DeleteFolderButton14.Background = new SolidColorBrush(Colors.Green); // ----------------------------------------------
                    }
                    else
                    {
                        // Найден, попытка удаления
                        ProcessStartInfo startInfoRemove = new ProcessStartInfo
                        {
                            FileName = "powershell.exe",
                            Arguments = $"-NoProfile -ExecutionPolicy Bypass -Command \"{removeCommand}\"",
                            UseShellExecute = false,
                            RedirectStandardOutput = true,
                            CreateNoWindow = true
                        };

                        using (Process processRemove = Process.Start(startInfoRemove))
                        {
                            processRemove.WaitForExit();
                            if (processRemove.ExitCode == 0)
                            {
                                // Skype успешно удален
                                DeleteFolderButton14.Background = new SolidColorBrush(Colors.Green); // -------------------------------------
                            }
                            else
                            {
                                // Ошибка при удалении Skype
                                DeleteFolderButton14.Background = new SolidColorBrush(Colors.Red); // ---------------------------------------
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                DeleteFolderButton14.Background = new SolidColorBrush(Colors.Red);
            }
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            string packageName = "Microsoft.MixedReality.Portal"; // ------------------------------------------------------------------------------
            string checkCommand = $"Get-AppxPackage -Name {packageName}";
            string removeCommand = $"Get-AppxPackage -Name {packageName} | Remove-AppxPackage";

            ProcessStartInfo startInfoCheck = new ProcessStartInfo
            {
                FileName = "powershell.exe",
                Arguments = $"-NoProfile -ExecutionPolicy Bypass -Command \"{checkCommand}\"",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = true
            };

            try
            {
                // Проверка наличия
                using (Process processCheck = Process.Start(startInfoCheck))
                {
                    string output = processCheck.StandardOutput.ReadToEnd();
                    processCheck.WaitForExit();

                    if (string.IsNullOrWhiteSpace(output))
                    {
                        // Не найден
                        DeleteFolderButton15.Background = new SolidColorBrush(Colors.Green); // ----------------------------------------------
                    }
                    else
                    {
                        // Найден, попытка удаления
                        ProcessStartInfo startInfoRemove = new ProcessStartInfo
                        {
                            FileName = "powershell.exe",
                            Arguments = $"-NoProfile -ExecutionPolicy Bypass -Command \"{removeCommand}\"",
                            UseShellExecute = false,
                            RedirectStandardOutput = true,
                            CreateNoWindow = true
                        };

                        using (Process processRemove = Process.Start(startInfoRemove))
                        {
                            processRemove.WaitForExit();
                            if (processRemove.ExitCode == 0)
                            {
                                // Skype успешно удален
                                DeleteFolderButton15.Background = new SolidColorBrush(Colors.Green); // -------------------------------------
                            }
                            else
                            {
                                // Ошибка при удалении Skype
                                DeleteFolderButton15.Background = new SolidColorBrush(Colors.Red); // ---------------------------------------
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                DeleteFolderButton15.Background = new SolidColorBrush(Colors.Red);
            }
        }

        private void Button_Click_16(object sender, RoutedEventArgs e)
        {
            string packageName = "Microsoft.MicrosoftSolitaireCollection"; // ------------------------------------------------------------------------------
            string checkCommand = $"Get-AppxPackage -Name {packageName}";
            string removeCommand = $"Get-AppxPackage -Name {packageName} | Remove-AppxPackage";

            ProcessStartInfo startInfoCheck = new ProcessStartInfo
            {
                FileName = "powershell.exe",
                Arguments = $"-NoProfile -ExecutionPolicy Bypass -Command \"{checkCommand}\"",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = true
            };

            try
            {
                // Проверка наличия
                using (Process processCheck = Process.Start(startInfoCheck))
                {
                    string output = processCheck.StandardOutput.ReadToEnd();
                    processCheck.WaitForExit();

                    if (string.IsNullOrWhiteSpace(output))
                    {
                        // Не найден
                        DeleteFolderButton16.Background = new SolidColorBrush(Colors.Green); // ----------------------------------------------
                    }
                    else
                    {
                        // Найден, попытка удаления
                        ProcessStartInfo startInfoRemove = new ProcessStartInfo
                        {
                            FileName = "powershell.exe",
                            Arguments = $"-NoProfile -ExecutionPolicy Bypass -Command \"{removeCommand}\"",
                            UseShellExecute = false,
                            RedirectStandardOutput = true,
                            CreateNoWindow = true
                        };

                        using (Process processRemove = Process.Start(startInfoRemove))
                        {
                            processRemove.WaitForExit();
                            if (processRemove.ExitCode == 0)
                            {
                                // Успешно удален
                                DeleteFolderButton16.Background = new SolidColorBrush(Colors.Green); // -------------------------------------
                            }
                            else
                            {
                                // Ошибка при удалении
                                DeleteFolderButton16.Background = new SolidColorBrush(Colors.Red); // ---------------------------------------
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                DeleteFolderButton16.Background = new SolidColorBrush(Colors.Red);
            }
        }

        private void Button_Click_17(object sender, RoutedEventArgs e)
        {
            string packageName = "Microsoft.MicrosoftSolitaireCollection"; // ------------------------------------------------------------------------------
            string checkCommand = $"Get-AppxPackage -Name {packageName}";
            string removeCommand = $"Get-AppxPackage -Name {packageName} | Remove-AppxPackage";

            ProcessStartInfo startInfoCheck = new ProcessStartInfo
            {
                FileName = "powershell.exe",
                Arguments = $"-NoProfile -ExecutionPolicy Bypass -Command \"{checkCommand}\"",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = true
            };

            try
            {
                // Проверка наличия
                using (Process processCheck = Process.Start(startInfoCheck))
                {
                    string output = processCheck.StandardOutput.ReadToEnd();
                    processCheck.WaitForExit();

                    if (string.IsNullOrWhiteSpace(output))
                    {
                        // Не найден
                        DeleteFolderButton17.Background = new SolidColorBrush(Colors.Green); // ----------------------------------------------
                    }
                    else
                    {
                        // Найден, попытка удаления
                        ProcessStartInfo startInfoRemove = new ProcessStartInfo
                        {
                            FileName = "powershell.exe",
                            Arguments = $"-NoProfile -ExecutionPolicy Bypass -Command \"{removeCommand}\"",
                            UseShellExecute = false,
                            RedirectStandardOutput = true,
                            CreateNoWindow = true
                        };

                        using (Process processRemove = Process.Start(startInfoRemove))
                        {
                            processRemove.WaitForExit();
                            if (processRemove.ExitCode == 0)
                            {
                                // Успешно удален
                                DeleteFolderButton17.Background = new SolidColorBrush(Colors.Green); // -------------------------------------
                            }
                            else
                            {
                                // Ошибка при удалении
                                DeleteFolderButton17.Background = new SolidColorBrush(Colors.Red); // ---------------------------------------
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                DeleteFolderButton17.Background = new SolidColorBrush(Colors.Red);
            }
        }

        private void Button_Click_18(object sender, RoutedEventArgs e)
        {
            string packageName = "Microsoft.ScreenSketch"; // ------------------------------------------------------------------------------
            string checkCommand = $"Get-AppxPackage -Name {packageName}";
            string removeCommand = $"Get-AppxPackage -Name {packageName} | Remove-AppxPackage";

            ProcessStartInfo startInfoCheck = new ProcessStartInfo
            {
                FileName = "powershell.exe",
                Arguments = $"-NoProfile -ExecutionPolicy Bypass -Command \"{checkCommand}\"",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = true
            };

            try
            {
                // Проверка наличия
                using (Process processCheck = Process.Start(startInfoCheck))
                {
                    string output = processCheck.StandardOutput.ReadToEnd();
                    processCheck.WaitForExit();

                    if (string.IsNullOrWhiteSpace(output))
                    {
                        // Не найден
                        DeleteFolderButton18.Background = new SolidColorBrush(Colors.Green); // ----------------------------------------------
                    }
                    else
                    {
                        // Найден, попытка удаления
                        ProcessStartInfo startInfoRemove = new ProcessStartInfo
                        {
                            FileName = "powershell.exe",
                            Arguments = $"-NoProfile -ExecutionPolicy Bypass -Command \"{removeCommand}\"",
                            UseShellExecute = false,
                            RedirectStandardOutput = true,
                            CreateNoWindow = true
                        };

                        using (Process processRemove = Process.Start(startInfoRemove))
                        {
                            processRemove.WaitForExit();
                            if (processRemove.ExitCode == 0)
                            {
                                // Успешно удален
                                DeleteFolderButton18.Background = new SolidColorBrush(Colors.Green); // -------------------------------------
                            }
                            else
                            {
                                // Ошибка при удалении
                                DeleteFolderButton18.Background = new SolidColorBrush(Colors.Red); // ---------------------------------------
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                DeleteFolderButton18.Background = new SolidColorBrush(Colors.Red);
            }
        }

       
     

        private void Button_Click_21(object sender, RoutedEventArgs e)
        {
            string packageName = "Microsoft.549981C3F5F10"; // ------------------------------------------------------------------------------
            string checkCommand = $"Get-AppxPackage -Name {packageName}";
            string removeCommand = $"Get-AppxPackage -Name {packageName} | Remove-AppxPackage";

            ProcessStartInfo startInfoCheck = new ProcessStartInfo
            {
                FileName = "powershell.exe",
                Arguments = $"-NoProfile -ExecutionPolicy Bypass -Command \"{checkCommand}\"",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = true
            };

            try
            {
                // Проверка наличия
                using (Process processCheck = Process.Start(startInfoCheck))
                {
                    string output = processCheck.StandardOutput.ReadToEnd();
                    processCheck.WaitForExit();

                    if (string.IsNullOrWhiteSpace(output))
                    {
                        // Не найден
                        DeleteFolderButton21.Background = new SolidColorBrush(Colors.Green); // ----------------------------------------------
                    }
                    else
                    {
                        // Найден, попытка удаления
                        ProcessStartInfo startInfoRemove = new ProcessStartInfo
                        {
                            FileName = "powershell.exe",
                            Arguments = $"-NoProfile -ExecutionPolicy Bypass -Command \"{removeCommand}\"",
                            UseShellExecute = false,
                            RedirectStandardOutput = true,
                            CreateNoWindow = true
                        };

                        using (Process processRemove = Process.Start(startInfoRemove))
                        {
                            processRemove.WaitForExit();
                            if (processRemove.ExitCode == 0)
                            {
                                // Успешно удален
                                DeleteFolderButton21.Background = new SolidColorBrush(Colors.Green); // -------------------------------------
                            }
                            else
                            {
                                // Ошибка при удалении
                                DeleteFolderButton21.Background = new SolidColorBrush(Colors.Red); // ---------------------------------------
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                DeleteFolderButton21.Background = new SolidColorBrush(Colors.Red);
            }
        }



        private async void Button_Click_30(object sender, RoutedEventArgs e)
        {
            Button_Click_1(sender, e);
            await Task.Delay(100); // небольшая задержка для имитации асинхронности

            Button_Click_2(sender, e);
            await Task.Delay(100); // небольшая задержка для имитации асинхронности

            Button_Click_3(sender, e);
            await Task.Delay(100); // небольшая задержка для имитации асинхронности

            Button_Click_4(sender, e);
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


            Button_Click_21(sender, e);
            await Task.Delay(100); // небольшая задержка для имитации асинхронности




            DeleteFolderButton30.Background = new SolidColorBrush(Colors.Green); // ----------------------------------------------

            
        }





    }
}
