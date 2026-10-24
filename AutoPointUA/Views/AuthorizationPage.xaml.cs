using System;

using AutoPointUA.ViewModels;

using Windows.UI.Xaml.Controls;

namespace AutoPointUA.Views
{
    public sealed partial class AuthorizationPage : Page
    {
        public AuthorizationViewModel ViewModel { get; } = new AuthorizationViewModel();

        public AuthorizationPage()
        {
            InitializeComponent();
        }
    }
}
