using System.Windows;
using System.Windows.Controls;
using XCeedStylesApplication.Services;
using XCeedStylesApplication.Views;

namespace XCeedStylesApplication
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
        }

        private void OnStartup(object sender, StartupEventArgs e)
        {
            var window = new ShellWindow();
            var frame = window.Content as Frame;
            NavigationService.Initialize(frame);
            window.Show();
        }
    }
}
