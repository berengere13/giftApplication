using GiftsProject.Models;
using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GiftsProject.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        private void MesEnvies_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MesEnviesPage());

        }

        private void LeursEnvies_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LeursEnviesPage());
        }
    }
}