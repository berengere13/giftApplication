using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.Media;
using GiftApp.Models;
using GiftApp.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GiftApp.Views
{
	public partial class ListUsers
	{
		public ListUsers()
		{
			InitializeComponent();
		    BindingContext = this;

		    var dataBaseService = new DataBaseService();
		    InitData(dataBaseService);
		}

	    private async void InitData(DataBaseService dataBaseService)
	    {
	        ItemsSource = await dataBaseService.GetUsersFromDataBase();
        }

	    public IList<User> ItemsSource { get; set; }
	}
}