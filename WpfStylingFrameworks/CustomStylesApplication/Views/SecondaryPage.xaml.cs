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

namespace CustomStylesApplication.Views
{
    /// <summary>
    /// Interaction logic for SecondaryPage.xaml
    /// </summary>
    public partial class SecondaryPage : Page
    {
        public SecondaryPage()
        {
            InitializeComponent();
        }

        private void OnGoBackButtonClick(object sender, RoutedEventArgs e)
        {
            Services.NavigationService.GoBack();
        }
    }
}
