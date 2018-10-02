using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Input;
using Firebase.Database;
using GiftApp.Models;
using GiftApp.Views;
using Xamarin.Forms;

namespace GiftApp
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
