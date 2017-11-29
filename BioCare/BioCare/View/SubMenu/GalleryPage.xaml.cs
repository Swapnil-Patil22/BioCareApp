using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BioCare.View.SubMenu
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class GalleryPage : ContentPage
	{
		public GalleryPage ()
		{
			InitializeComponent ();
		}
        private void CompletedUpload_OnTapped(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new ProfilePage());

        }
    }
}