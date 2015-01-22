using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace PaperIT
{
	[Activity (Label = "PaperIT", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			var txtBook   = FindViewById<EditText> (Resource.Id.txtBook);
			var btnSearch = FindViewById<Button> (Resource.Id.btnSearch);
			var lswBooks = FindViewById<ListView> (Resource.Id.lswBooks);

			btnSearch.Click += async (sender, e) => {
				var itEbook_api = new Shared.itEbook_api();
				var booksIT = await itEbook_api.GetAsync(txtBook.Text);
				lswBooks.Adapter = new ArrayAdapter(this, Android.Resource.Layout.SimpleListItemSingleChoice, booksIT);

			};
		}
	}
}


