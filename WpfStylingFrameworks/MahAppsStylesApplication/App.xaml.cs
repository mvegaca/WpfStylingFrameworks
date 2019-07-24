using MahAppsStylesApplication.Services;
using System;
using MahAppsStylesApplication.Views;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace MahAppsStylesApplication
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