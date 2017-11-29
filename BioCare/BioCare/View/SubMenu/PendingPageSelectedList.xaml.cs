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
        public PendingPageSelectedList()
        {
            InitializeComponent();
        }
        public PendingPageSelectedList (BookingModel item)
		{
			InitializeComponent ();

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
                Navigation.PushAsync(new EquipmentListPage());
               
            };
            HamBurgerImg.GestureRecognizers.Add(tapGestureRecognizer);

        }

        private void StartWork_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new StartWorkPage());
        }


        private void BNo_Focused(object sender, FocusEventArgs e)
        {
   
        }
    }
}