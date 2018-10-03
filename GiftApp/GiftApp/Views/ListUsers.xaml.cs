using System.Collections.Generic;
using GiftApp.Models;
using GiftApp.Services;

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