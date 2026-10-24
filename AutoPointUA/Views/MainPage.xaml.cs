using Windows.UI.Xaml.Controls;

namespace AutoPointUA.Views
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void NavigateToSellCarPage(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            Frame.Navigate(typeof(SellCarPage));
        }

        private void NavigateToAnnouncementPage(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            Frame.Navigate(typeof(AnnouncementPage));
        }
    }
}
