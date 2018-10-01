using System;
using System.IO;
using System.Windows.Input;
using Firebase.Database;
using Xamarin.Forms;

namespace GiftApp
{
    public partial class MainPage
    {
     
        string FirebaseURL = App.Current.Resources["secrets.json"].ToString();

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
