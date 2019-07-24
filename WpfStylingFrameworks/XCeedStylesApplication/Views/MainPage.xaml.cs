using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using XCeedStylesApplication.ViewModels;

namespace XCeedStylesApplication.Views
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainViewModel ViewModel { get; } = new MainViewModel();
        public MainPage()
        {
            InitializeComponent();
            DataContext = ViewModel;
        }

        private async void OnLoaded(object sender, RoutedEventArgs e)
        {
            await ViewModel.LoadDataAsync();
        }

        private void OnNavigateButtonClick(object sender, RoutedEventArgs e)
        {
            Services.NavigationService.Navigate(new SecondaryPage());
        }
    }
}
