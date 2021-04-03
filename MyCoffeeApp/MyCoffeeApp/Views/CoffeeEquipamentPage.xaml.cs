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

            // Pode se ligar assim ou adiconar direto no *.Xaml
            //BindingContext = new CoffeeEquipmentViewModel();
        }       
        
    }
}