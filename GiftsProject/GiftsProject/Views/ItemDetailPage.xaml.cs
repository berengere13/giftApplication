﻿using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GiftsProject.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemDetailPage : ContentPage
    {
      
        public ItemDetailPage()
        {
            InitializeComponent();

            BindingContext = this;
        }
       
    }
}