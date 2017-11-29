using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Syncfusion.SfCalendar.XForms;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Globalization;

namespace BioCare.View.SubMenu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CalendarPage : ContentPage
    {
        // SfCalendar calendar = new SfCalendar();

        public CalendarPage()
        {
            InitializeComponent();

            //calendar.MinDate = new DateTime(2014, 4, 1);
            //calendar.MaxDate = new DateTime(2018, 4, 1);

            // this.Content = calendar;
            calendar.WidthRequest = 300;
            calendar.HeightRequest = 300;
            calendar.OnCalendarTapped += Calendar_OnCalendarTapped;
        }

        private void Calendar_OnCalendarTapped(object sender, CalendarTappedEventArgs args)
        {
            DateTime dt1 = DateTime.Now;
            String CalTime = "";

            String Mer = "";

            Mer = dt1.ToString("tt", CultureInfo.InvariantCulture);

            CalTime = dt1.ToString("HH : mm :ss");

            //var CalTotTime = CalTime + " " + Mer;
            CTime.Text = CalTime;
            var Day = calendar.SelectedDate.Day.ToString();
            var month = calendar.SelectedDate.Month.ToString();
            var Year = calendar.SelectedDate.Year.ToString();

            var WeekDay = calendar.SelectedDate.DayOfWeek;

            SelectDate.Text = (string.Format("{0}  {1} ", Day, WeekDay));
           

            BNo.Text = "BN00001";
            Loc.Text = "Singapore";
        }
    }
}