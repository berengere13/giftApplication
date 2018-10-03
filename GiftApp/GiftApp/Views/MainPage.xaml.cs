using System.Windows.Input;
using Xamarin.Forms;

namespace GiftApp.Views
{
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        public ICommand _seeMyEnviesCommand { get; set; }
        public ICommand _seeAllEnviesCommand { get; set; }

        public ICommand SeeMyEnviesCommand => _seeMyEnviesCommand ?? new Command(() =>
                                                  {
                                                      Navigation.PushAsync(new MesEnviesPage());
                                                  });
        public ICommand SeeAllEnviesCommand => _seeAllEnviesCommand ?? new Command(async() =>
        {
            await Navigation.PushAsync(new ListUsers());
        });

    }
}
