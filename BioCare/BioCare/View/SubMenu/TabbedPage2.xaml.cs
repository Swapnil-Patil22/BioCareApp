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
	public partial class TabbedPage2 : TabbedPage
	{
		public TabbedPage2 ()
		{
            
            InitializeComponent ();

            var navigationPage1 = new NavigationPage(new PendingBookingPage());
            // navigationPage.Title = "Completed Booking";

            var navigationPage = new NavigationPage(new CompletedBookingPage());
            //navigationPage1.Title = "Pending Booking";

            Children.Add(new PendingBookingPage());
            // Children.Add(navigationPage);

            Children.Add(new CompletedBookingPage());
            // Children.Add(navigationPage1);
 
        }
	}
}