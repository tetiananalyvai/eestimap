using Microsoft.Maui.Controls;

namespace MauiEEkaart
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent(); // Этот вызов обязателен!
        }

        private async void OnTallinnButtonClicked(object sender, EventArgs e)
        {
            // Переход на страницу TallinnPage
            await Navigation.PushAsync(new TallinnPage());
        }
        private async void OnTartuButtonClicked(object sender, EventArgs e)
        {
            // Переход на страницу TallinnPage
            await Navigation.PushAsync(new TartuPage());
        }
        private async void OnParnuButtonClicked(object sender, EventArgs e)
        {
            // Переход на страницу TallinnPage
            await Navigation.PushAsync(new ParnuPage());
        }
        private async void OnNarvaButtonClicked(object sender, EventArgs e)
        {
            // Переход на страницу TallinnPage
            await Navigation.PushAsync(new NarvaPage());
        }
    }

}
