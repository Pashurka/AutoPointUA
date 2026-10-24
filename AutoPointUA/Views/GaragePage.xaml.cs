using System;
using AutoPointUA.ViewModels;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace AutoPointUA.Views
{
    public sealed partial class GaragePage : Page
    {
        public GarageViewModel ViewModel { get; } = new GarageViewModel();

        public GaragePage()
        {
            InitializeComponent();
        }

        private void NavigateAudiViewPage(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(AudiViewPage));
        }

        private void NavigateTeslaViewPage(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(TeslaViewPage));
        }
    }
}
