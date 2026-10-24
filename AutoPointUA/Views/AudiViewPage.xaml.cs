using System;

using AutoPointUA.ViewModels;

using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media.Imaging;

namespace AutoPointUA.Views
{
    public sealed partial class AudiViewPage : Page
    {
        public AudiViewViewModel ViewModel { get; } = new AudiViewViewModel();

        public AudiViewPage()
        {
            InitializeComponent();
        }
        private async void Image_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (sender is Image image && image.Source is BitmapImage bitmap)
            {
                ContentDialog imageDialog = new ContentDialog
                {
                    Title = "Перегляд зображення",
                    Content = new Image
                    {
                        Source = bitmap,
                        Stretch = Windows.UI.Xaml.Media.Stretch.Uniform
                    },
                    PrimaryButtonText = "Закрити",
                    XamlRoot = this.XamlRoot // Додаємо, якщо використовуємо WinUI 3
                };

                await imageDialog.ShowAsync().AsTask(); // Використовуємо AsTask() для правильного очікування
            }
        }
    }

}
