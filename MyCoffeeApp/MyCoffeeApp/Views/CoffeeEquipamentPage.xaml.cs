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

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {

        }
        private void MenuItem_Clicked(object sender, System.EventArgs e)
        {

        }
    }
}