using System;
using System.Collections.Generic;
using System.IO;
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

namespace cfx_cleaner_wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Beaver_Logo_Click(object sender, RoutedEventArgs e)
        {
            var destinationurl = "https://tripout.tech/";
            var sInfo = new System.Diagnostics.ProcessStartInfo(destinationurl)
            {
                UseShellExecute = true,
            };
            System.Diagnostics.Process.Start(sInfo);
        }
        private void FiveM_Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Dispatcher.Invoke(() =>
            {
                Mouse.OverrideCursor = Cursors.Wait;
            });
            string fivem_appdata = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\AppData\\Local\\FiveM\\FiveM.app\\data\\";
            if (Directory.Exists(fivem_appdata))
            {
                string fivem_cache = fivem_appdata + "\\cache\\";
                string fivem_server_cache = fivem_appdata + "\\server-cache\\";
                string fivem_server_priv = fivem_appdata + "\\server-cache-priv\\";
                DirectoryInfo cache_info = new DirectoryInfo(fivem_cache);
                DirectoryInfo server_info = new DirectoryInfo(fivem_server_cache);
                DirectoryInfo server_priv_info = new DirectoryInfo(fivem_server_priv);
                long cache_size = cache_info.EnumerateFiles().Sum(file => file.Length);
                long server_size = server_info.EnumerateFiles().Sum(file => file.Length);
                long server_priv_size = server_priv_info.EnumerateFiles().Sum(file => file.Length);
                long fivem_total_size = cache_size + server_size + server_priv_size;
                Directory.Delete(fivem_cache, true);
                Directory.Delete(fivem_server_cache, true);
                Directory.Delete(fivem_server_priv, true);
                string messageBoxText = "Approx " + fivem_total_size / (1024 * 1024) + "MB cleaned.";
                string caption = "FiveM Cache Cleaner Complete";
                MessageBoxButton button = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.Information;
                MessageBoxResult result;
                Application.Current.Dispatcher.Invoke(() =>
                {
                    Mouse.OverrideCursor = null;
                });
                result = MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.Yes);
            }
            else
            {
                string messageBoxText = "Error, Cannot Find FiveM Application Directory!";
                string caption = "FiveM Cache Cleaner Error";
                MessageBoxButton button = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.Error;
                MessageBoxResult result;
                Application.Current.Dispatcher.Invoke(() =>
                {
                    Mouse.OverrideCursor = null;
                });
                result = MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.Yes);
            }
        }
        private void RedM_Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Dispatcher.Invoke(() =>
            {
                Mouse.OverrideCursor = Cursors.Wait;
            });
            string redm_appdata = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\AppData\\Local\\RedM\\RedM.app\\data\\";
            if (Directory.Exists(redm_appdata))
            {
                string redm_cache = redm_appdata + "\\cache\\";
                string redm_server_cache = redm_appdata + "\\server-cache\\";
                string redm_server_priv = redm_appdata + "\\server-cache-priv\\";
                DirectoryInfo cache_info = new DirectoryInfo(redm_cache);
                DirectoryInfo server_info = new DirectoryInfo(redm_server_cache);
                DirectoryInfo server_priv_info = new DirectoryInfo(redm_server_priv);
                long cache_size = cache_info.EnumerateFiles().Sum(file => file.Length);
                long server_size = server_info.EnumerateFiles().Sum(file => file.Length);
                long server_priv_size = server_priv_info.EnumerateFiles().Sum(file => file.Length);
                long redm_total_size = cache_size + server_size + server_priv_size;
                Directory.Delete(redm_cache, true);
                Directory.Delete(redm_server_cache, true);
                Directory.Delete(redm_server_priv, true);
                string messageBoxText = "Approx " + redm_total_size / (1024 * 1024) + "MB cleaned.";
                string caption = "RedM Cache Cleaner Complete";
                MessageBoxButton button = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.Information;
                MessageBoxResult result;
                Application.Current.Dispatcher.Invoke(() =>
                {
                    Mouse.OverrideCursor = null;
                });
                result = MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.Yes);
            }
            else
            {
                string messageBoxText = "Error, Cannot Find RedM Application Directory!";
                string caption = "RedM Cache Cleaner Error";
                MessageBoxButton button = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.Error;
                MessageBoxResult result;
                Application.Current.Dispatcher.Invoke(() =>
                {
                    Mouse.OverrideCursor = null;
                });
                result = MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.Yes);
            }
        }
    }
}
