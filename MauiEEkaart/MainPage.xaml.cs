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
    }
}
