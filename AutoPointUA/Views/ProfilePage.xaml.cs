using System;

using AutoPointUA.ViewModels;

using Windows.UI.Xaml.Controls;

namespace AutoPointUA.Views
{
    public sealed partial class ProfilePage : Page
    {
        public ProfileViewModel ViewModel { get; } = new ProfileViewModel();

        public ProfilePage()
        {
            InitializeComponent();
        }
    }
}
