using System;
using System.Collections.Generic;
using System.IO;
using TwitterProjectClient.ViewModels;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Controls;

namespace TwitterProjectClient.Views
{
    public sealed partial class LoginWebPage : Page
    {
        public LoginWebPage()
        {
            InitializeComponent();
            NavigationCacheMode = NavigationCacheMode.Disabled;
        }
    }
}