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
    /// Interaction logic for SecondaryPage.xaml
    /// </summary>
    public partial class SecondaryPage : Page
    {
        public SecondaryViewModel ViewModel { get; } = new SecondaryViewModel();

        public SecondaryPage()
        {
            InitializeComponent();
            DataContext = ViewModel;
        }

        private void OnGoBackButtonClick(object sender, RoutedEventArgs e)
        {
            Services.NavigationService.GoBack();
        }
    }
}
