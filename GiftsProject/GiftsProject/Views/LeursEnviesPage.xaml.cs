using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GiftsProject.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LeursEnviesPage : ContentPage
    {
        public LeursEnviesPage()
        {
            InitializeComponent();
            BindingContext = this;
        }

      
    }
}