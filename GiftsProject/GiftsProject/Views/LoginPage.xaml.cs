using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GiftsProject.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
		public LoginPage()
		{
			InitializeComponent();
		    BindingContext = this;
		}

	    private void Button_OnClicked(object sender, EventArgs e)
	    {
	        Application.Current.Properties["prenom"] = Prenom;
	        Navigation.PopAsync(true);
            Navigation.RemovePage(this);
	    }
        
	    public bool IsLoginIsEnabled { get; set; }

	    public string Prenom { get; set; }

	    private void LoginChanged(object sender, TextChangedEventArgs e)
	    {
	        IsLoginIsEnabled = !string.IsNullOrEmpty(e.NewTextValue);
	    }
	}
}