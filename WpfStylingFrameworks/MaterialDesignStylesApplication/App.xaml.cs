using MaterialDesignStylesApplication.Services;
using MaterialDesignStylesApplication.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace MaterialDesignStylesApplication
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void OnStartup(object sender, StartupEventArgs e)
        {
            var window = new ShellWindow();
            var frame = window.Content as Frame;
            NavigationService.Initialize(frame);
            window.Show();
        }
    }
}
