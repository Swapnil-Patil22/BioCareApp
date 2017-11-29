using BioCare.Model;
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
	public partial class NotificationsPageSelected : ContentPage
	{

        private NotificationModel notificationModel;

        public NotificationsPageSelected (NotificationModel item)
		{
			InitializeComponent ();
            //NId.Text = item.Id.ToString();
            //ENName.Text = item.Name.ToString();
            //NName.Text = item.Name.ToString();

            NNum.Text = item.Number.ToString();
            ENBNo.Text = item.BookingNo.ToString();
           NBNo.Text = item.BookingNo.ToString();

            ENDate.Text = item.Date.ToString();
            NDate.Text = item.Date.ToString();

            ENTitle.Text = item.Title.ToString();
            NTitle.Text = item.Title.ToString();

            ENDescription.Text = item.Description.ToString();
            NDescription.Text = item.Description.ToString();

            
            
            NNum.IsEnabled = false;
            NBNo.IsEnabled = false;
            NDate.IsEnabled = false;
            NTitle.IsEnabled = false;
            NDescription.IsEnabled = false;

           

            //var tapGestureRecognizer = new TapGestureRecognizer();
            //tapGestureRecognizer.Tapped += (s, e) =>
            //{
            //    // handle the tap
            //    //ID.IsEnabled = true;
            //    ENName.IsVisible = true;
            //    ENBNo.IsVisible = true;
            //    ENDate.IsVisible = true;
            //    ENTitle.IsVisible = true;
            //    ENDescription.IsVisible = true;


            //    NName.IsVisible = false;
            //    NBNo.IsVisible = false;
            //    NDate.IsVisible = false;
            //    NTitle.IsVisible = false;
            //    NDescription.IsVisible = false;


            //    //NBNo.IsEnabled = true;
            //    //NDate.IsEnabled = true;
            //    //NTitle.IsEnabled = true;
            //    //NDescription.IsEnabled = true;

            //    completeCloseNImage.IsVisible = true;
            //    editNImage.IsVisible = false;
            //    btnCompleteNConfirm.IsVisible = true;

            //};
            //editNImage.GestureRecognizers.Add(tapGestureRecognizer);

            //var ClosetapGestureRecognizer = new TapGestureRecognizer();
            //ClosetapGestureRecognizer.Tapped += (s, e) =>
            //{
            //    // handle the tap
            //    //ID.IsEnabled = false;
            //    //NName.IsEnabled = false;
            //    //NBNo.IsEnabled = false;
            //    //NDate.IsEnabled = false;
            //    //NTitle.IsEnabled = false;
            //    //NDescription.IsEnabled = false;

            //    completeCloseNImage.IsVisible = false;
            //    editNImage.IsVisible = true;
            //    btnCompleteNConfirm.IsVisible = false;

            //    ENName.IsVisible = false;
            //    ENBNo.IsVisible = false;
            //    ENDate.IsVisible = false;
            //    ENTitle.IsVisible = false;
            //    ENDescription.IsVisible = false;

            //    NName.IsVisible = true;
            //    NBNo.IsVisible = true;
            //    NDate.IsVisible = true;
            //    NTitle.IsVisible = true;
            //    NDescription.IsVisible = true;

            //};
            //completeCloseNImage.GestureRecognizers.Add(ClosetapGestureRecognizer);

        }
	}
}