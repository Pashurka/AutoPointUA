using System;

using AutoPointUA.ViewModels;

using Windows.UI.Xaml.Controls;

namespace AutoPointUA.Views
{
    public sealed partial class SellCarPage : Page
    {
        public SellCarViewModel ViewModel { get; } = new SellCarViewModel();

        public SellCarPage()
        {
            InitializeComponent();
        }
    }
}
