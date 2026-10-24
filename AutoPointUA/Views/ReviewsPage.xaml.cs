using System;

using AutoPointUA.ViewModels;

using Windows.UI.Xaml.Controls;

namespace AutoPointUA.Views
{
    public sealed partial class ReviewsPage : Page
    {
        public ReviewsViewModel ViewModel { get; } = new ReviewsViewModel();

        public ReviewsPage()
        {
            InitializeComponent();
        }
    }
}
