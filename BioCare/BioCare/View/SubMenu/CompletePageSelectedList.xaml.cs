using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BioCare.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BioCare.View.SubMenu
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CompletePageSelectedList : ContentPage
	{
        private BookingModel bookingModel;
        bool hamburgertapped;
        public CompletePageSelectedList (BookingModel item)
		{
			InitializeComponent ();

            hamburgertapped = false;
            //ID.Text = item.Id.ToString();
            BNo.Text = item.BookingNo;
            ADT.Text = item.AppointmentDateTime;
            AS.Text = item.ActualStart;
            AE.Text = item.ActualEnd;
            DUR.Text = item.Duration;
            LOC.Text = item.Location;
            CNAME.Text = item.CustomerName;
            MOBNO.Text = item.MobileNo;
            TOS.Text = item.TypeOfService;
            LOC.Text = item.Location;
            STAT.Text = item.Status;
            VEH.Text = item.VehicleNo;
            //EQUIP.Text = item.ListOfEquipment;
            TNAME.Text = item.TeamName;
            TLEADER.Text = item.TeamLeader;
            WORK.Text = item.Workers;
            REMARK.Text = item.Remarks;

            var tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += (s, e) => {
                // handle the tap
                if (!hamburgertapped)
                {
                    //HamBurgerImg.IsEnabled = false;
                    Navigation.PushAsync(new EquipmentListPage());
                    //HamBurgerImg.IsEnabled = true;
                    hamburgertapped = true;
                }

            };
            tapGestureRecognizer.NumberOfTapsRequired = 1;
            HamBurgerImg.GestureRecognizers.Add(tapGestureRecognizer);

            //var tapGestureRecognizer = new TapGestureRecognizer();
            //tapGestureRecognizer.Tapped += (s, e) => {
            //    // handle the tap
            //    ID.IsEnabled = true;
            //    BNo.IsEnabled = true;
            //    ADT.IsEnabled = true;
            //    TOS.IsEnabled = true;
            //    LOC.IsEnabled = true;
            //    STAT.IsEnabled = true;
            //    VEH.IsEnabled = true;
            //    EQUIP.IsEnabled = true;
            //    TNAME.IsEnabled = true;
            //    TLEADER.IsEnabled = true;
            //    EMP.IsEnabled = true;
            //    completeCloseImage.IsVisible = true;
            //    editImage.IsVisible = false;
            //    btnCompleteConfirm.IsVisible = true;

            //};
            //editImage.GestureRecognizers.Add(tapGestureRecognizer);

            //var ClosetapGestureRecognizer = new TapGestureRecognizer();
            //ClosetapGestureRecognizer.Tapped += (s, e) => {
            //    // handle the tap
            //    ID.IsEnabled = false;
            //    BNo.IsEnabled = false;
            //    ADT.IsEnabled = false;
            //    TOS.IsEnabled = false;
            //    LOC.IsEnabled = false;
            //    STAT.IsEnabled = false;
            //    VEH.IsEnabled = false;
            //    EQUIP.IsEnabled = false;
            //    TNAME.IsEnabled = false;
            //    TLEADER.IsEnabled = false;
            //    EMP.IsEnabled = false;
            //    completeCloseImage.IsVisible = false;
            //    editImage.IsVisible = true;
            //    btnCompleteConfirm.IsVisible = false;
            //};
            //completeCloseImage.GestureRecognizers.Add(ClosetapGestureRecognizer);


        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            hamburgertapped = false;
        }


    }
}