﻿using MahAppsStylesApplication.Views;
using System.Windows.Controls;

namespace MahAppsStylesApplication.Services
{
    public static class NavigationService
    {
        private static Frame _frame;

        public static void Initialize(Frame frame)
        {
            _frame = frame;
            _frame.Navigate(new MainPage());
        }

        public static void Navigate(Page page)
            => _frame.Navigate(page);

        public static void GoBack()
            => _frame.GoBack();
    }
}
