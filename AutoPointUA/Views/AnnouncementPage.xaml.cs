using System;

using AutoPointUA.ViewModels;

using Windows.UI.Xaml.Controls;

namespace AutoPointUA.Views
{
    public sealed partial class AnnouncementPage : Page
    {
        public AnnouncementViewModel ViewModel { get; } = new AnnouncementViewModel();

        public AnnouncementPage()
        {
            InitializeComponent();
            this.DataContext = new AnnouncementViewModel();
        }
    }
}
