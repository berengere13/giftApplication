using GiftsProject.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GiftsProject.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();

            if (Application.Current.Properties["prenom"] == null)
            {
                Navigation.PushAsync(new LoginPage());
            }
        }
        
    }
}