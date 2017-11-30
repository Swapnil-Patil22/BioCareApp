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
	public partial class PendingPageSelectedList : ContentPage
	{
        bool hamburgertapped;
        public PendingPageSelectedList()
        {
            InitializeComponent();
        }
        public PendingPageSelectedList (BookingModel item)
		{
			InitializeComponent ();
            hamburgertapped = false;
            //ID.Text = item.Id.ToString();
            BNo.Text = item.BookingNo;
            ADT.Text = item.AppointmentDateTime;
            //AS.Text = item.ActualStart;
            //AE.Text = item.ActualEnd;
            //DUR.Text = item.Duration;
            LOC.Text = item.Location;
            CNAME.Text = item.CustomerName;
            MOBNO.Text = item.MobileNo;
            TOS.Text = item.TypeOfService;
            LOC.Text = item.Location;
           STAT.Text = item.Status;
            VEH.Text = item.VehicleNo;
          //  EQUIP.Text = item.ListOfEquipment;
            TNAME.Text = item.TeamName;
            TLEADER.Text = item.TeamLeader;
            WORK.Text = item.Workers;
            // REMARK.Text = item.Remarks;


            var tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += (s, e) => {
                // handle the tap
                if(!hamburgertapped)
                {
                    //HamBurgerImg.IsEnabled = false;
                    Navigation.PushAsync(new EquipmentListPage());
                    //HamBurgerImg.IsEnabled = true;
                    hamburgertapped = true;
                }

            };
            tapGestureRecognizer.NumberOfTapsRequired = 1;
            HamBurgerImg.GestureRecognizers.Add(tapGestureRecognizer);


        }

        private async void StartWork_OnClicked(object sender, EventArgs e)
        {
            btnPendingStart.IsEnabled = false;
            await Navigation.PushAsync(new StartWorkPage());
            btnPendingStart.IsEnabled = true;
        }

        private void BNo_Focused(object sender, FocusEventArgs e)
        {
   
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            hamburgertapped = false;
        }
    }
}