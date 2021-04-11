using MyCoffeeApp.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyCoffeeApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CoffeeEquipamentPage : ContentPage
    {
        
        public CoffeeEquipamentPage()
        {
            InitializeComponent();           
        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var coffee = ((ListView)sender).SelectedItem as Coffee;
            if (coffee == null)
                return;

            await DisplayAlert("Coffee Selected", coffee.Name, "OK");
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            ((ListView)sender).SelectedItem = null;
        }
        private async void MenuItem_Clicked(object sender, System.EventArgs e)
        {
            var coffee = ((MenuItem)sender).BindingContext as Coffee;
            if (coffee == null)
                return;

            await DisplayAlert("Coffee Favorited", coffee.Name, "OK");
        }
    }
}