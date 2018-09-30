using Firebase.Xamarin.Database;
using System.Windows.Input;
using Xamarin.Forms;

namespace GiftApp
{
    public partial class MainPage
    {
        
        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;

            var fireabase = new FirebaseClient(FirebaseURL);
            
        }

        public ICommand _seeMyEnviesCommand { get; set; }
        public ICommand _seeAllEnviesCommand { get; set; }

        public ICommand SeeMyEnviesCommand => _seeMyEnviesCommand ?? new Command(() =>
                                                  {
                                                      
                                                      DisplayAlert("Voir mes envies", "voir mes envies", "Annuler");
                                                  });
        public ICommand SeeAllEnviesCommand => _seeAllEnviesCommand ?? new Command(() =>
                                                  {
                                                      DisplayAlert("Voir leurs envies", "voir leurs envies", "Annuler");
                                                  });

    }
}
