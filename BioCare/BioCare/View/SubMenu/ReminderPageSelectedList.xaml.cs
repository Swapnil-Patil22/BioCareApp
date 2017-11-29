using BioCare.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rg.Plugins.Popup.Extensions;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using BioCare.View.Wizard;

namespace BioCare.View.SubMenu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ReminderPageSelectedList : ContentPage
    {
        private ReminderModel reminderModel;
 

        //private ReminderPageSelectedList()
        //{
           
        //    InitializeComponent();

        //    NavigationPage.SetHasNavigationBar(this, false);

        //    RName.Text = "Sample Name";
        //    RTitle.Text = "Title";
        //    RBNo.Text = "BN R0001";
        //    RDate.Text = "09/20/2017";
        //    RTime.Text = "11.AM";
        //    RDescription.Text = "Description of Reminders";


           


        //    RName.IsEnabled = false;
        //    RBNo.IsEnabled = false;
        //    RDate.IsEnabled = false;
        //    RTime.IsEnabled = false;
        //    RTitle.IsEnabled = false;
        //    RDescription.IsEnabled = false;

        //    ERName.IsVisible = false;
        //    ERBNo.IsVisible = false;
        //    ERDate.IsVisible = false;
        //    ERTime.IsVisible = false;
        //    ERTitle.IsVisible = false;
        //    ERDescription.IsVisible = false;

        //    RName.IsVisible = true;
        //    RBNo.IsVisible = true;
        //    RDate.IsVisible = true;
        //    RTime.IsVisible = true;
        //    RTitle.IsVisible = true;
        //    RDescription.IsVisible = true;
        //    backbtn.IsVisible = true;


        //    var tapGestureRecognizerbackbtn = new TapGestureRecognizer();
        //    tapGestureRecognizerbackbtn.Tapped += (s, e) =>
        //    {
        //        Navigation.PushAsync(new ReminderPage());
        //    };
        //    backbtn.GestureRecognizers.Add(tapGestureRecognizerbackbtn);




        //    var tapGestureRecognizer = new TapGestureRecognizer();
        //    tapGestureRecognizer.Tapped += (s, e) =>
        //    {
        //        // handle the tap
        //        //ID.IsEnabled = true;
        //        //RName.IsEnabled = true;
        //        //RBNo.IsEnabled = true;
        //        //RDate.IsEnabled = true;
        //        //RTime.IsEnabled = true;
        //        //RTitle.IsEnabled = true;
        //        //RDescription.IsEnabled = true;

        //        ERName.Text = "Sample Name";
        //        ERTitle.Text = "Title";
        //        ERBNo.Text = "BN R0001";
        //        ERDate.Text = "09/20/2017";
        //        ERTime.Text = "11.AM";
        //        ERDescription.Text = "Description of Reminders";

        //        ERName.IsVisible = true;
        //        ERBNo.IsVisible = true;
        //        ERDate.IsVisible = true;
        //        ERTime.IsVisible = true;
        //        ERTitle.IsVisible = true;
        //        ERDescription.IsVisible = true;

                

        //        RName.IsVisible = false;
        //        RBNo.IsVisible = false;
        //        RDate.IsVisible = false;
        //        RTime.IsVisible = false;
        //        RTitle.IsVisible = false;
        //        RDescription.IsVisible = false;

        //        completeCloseRImage.IsVisible = true;
        //        editRImage.IsVisible = false;
        //        btnCompleteRConfirm.IsVisible = true;

               

        //    };
        //    editRImage.GestureRecognizers.Add(tapGestureRecognizer);

        //    var ClosetapGestureRecognizer = new TapGestureRecognizer();
        //    ClosetapGestureRecognizer.Tapped += (s, e) =>
        //    {
        //        // handle the tap
        //        //ID.IsEnabled = false;
        //        //RName.IsEnabled = false;
        //        //RBNo.IsEnabled = false;
        //        //RDate.IsEnabled = false;
        //        //RTime.IsEnabled = false;
        //        //RTitle.IsEnabled = false;
        //        //RDescription.IsEnabled = false;

        //        ERName.IsVisible = false;
        //        ERBNo.IsVisible = false;
        //        ERDate.IsVisible = false;
        //        ERTime.IsVisible = false;
        //        ERTitle.IsVisible = false;
        //        ERDescription.IsVisible = false;

        //        RName.IsVisible = true;
        //        RBNo.IsVisible = true;
        //        RDate.IsVisible = true;
        //        RTime.IsVisible = true;
        //        RTitle.IsVisible = true;
        //        RDescription.IsVisible = true;

        //        completeCloseRImage.IsVisible = false;
        //        editRImage.IsVisible = true;
        //        btnCompleteRConfirm.IsVisible = false;
        //    };
        //    completeCloseRImage.GestureRecognizers.Add(ClosetapGestureRecognizer);
        //}

        //      protected override bool OnBackButtonPressed()
        //{
        //    //  base.OnBackButtonPressed();

        //    //  Navigation.RemovePage(Navigation.NavigationStack[Navigation.NavigationStack.Count - 1]);
        //    Navigation.PushAsync(new ReminderPage());
        //    base.OnBackButtonPressed();
          
        //    return true;
        //}



        public ReminderPageSelectedList(ReminderModel item)
        {
            InitializeComponent();
            // RId.Text = item.Id.ToString();
            //RName.Text = item.Name.ToString();
            //ERName.Text = item.Name.ToString();
            RNum.Text = item.Number.ToString();
            ERNum.Text = item.Number.ToString();

            RBNo.Text = item.BookingNo.ToString();
            ERBNo.Text = item.BookingNo.ToString();

            RDate.Text = item.Date.ToString();
            ERDate.Text = item.Date.ToString();

            RTime.Text = item.Time.ToString();
            ERTime.Text = item.Time.ToString();

            RTitle.Text = item.Title.ToString();
            ERTitle.Text = item.Title.ToString();

            RDescription.Text = item.Description.ToString();
            ERDescription.Text = item.Description.ToString();


            RNum.IsEnabled = false;
            RBNo.IsEnabled = false;
            RDate.IsEnabled = false;
            RTime.IsEnabled = false;
            RTitle.IsEnabled = false;
            RDescription.IsEnabled = false;

            ERNum.IsVisible = false;
            ERBNo.IsVisible = false;
            ERDate.IsVisible = false;
            ERTime.IsVisible = false;
            ERTitle.IsVisible = false;
            ERDescription.IsVisible = false;

            RNum.IsVisible = true;
            RBNo.IsVisible = true;
            RDate.IsVisible = true;
            RTime.IsVisible = true;
            RTitle.IsVisible = true;
            RDescription.IsVisible = true;

           


            var tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += (s, e) =>
            {
                // handle the tap
                //ID.IsEnabled = true;
                //RName.IsEnabled = true;
                //RBNo.IsEnabled = true;
                //RDate.IsEnabled = true;
                //RTime.IsEnabled = true;
                //RTitle.IsEnabled = true;
                //RDescription.IsEnabled = true;

                ERNum.IsVisible = true;
                ERBNo.IsVisible = true;
                ERDate.IsVisible = true;
                ERTime.IsVisible = true;
                ERTitle.IsVisible = true;
                ERDescription.IsVisible = true;

                RNum.IsVisible = false;
                RBNo.IsVisible = false;
                RDate.IsVisible = false;
                RTime.IsVisible = false;
                RTitle.IsVisible = false;
                RDescription.IsVisible = false;

                completeCloseRImage.IsVisible = true;
                editRImage.IsVisible = false;
                btnCompleteRConfirm.IsVisible = true;

            };
            editRImage.GestureRecognizers.Add(tapGestureRecognizer);

            var ClosetapGestureRecognizer = new TapGestureRecognizer();
            ClosetapGestureRecognizer.Tapped += (s, e) =>
            {
                // handle the tap
                //ID.IsEnabled = false;
                //RName.IsEnabled = false;
                //RBNo.IsEnabled = false;
                //RDate.IsEnabled = false;
                //RTime.IsEnabled = false;
                //RTitle.IsEnabled = false;
                //RDescription.IsEnabled = false;
                ERNum.IsVisible = false;
                //ERName.IsVisible = false;
                ERBNo.IsVisible = false;
                ERDate.IsVisible = false;
                ERTime.IsVisible = false;
                ERTitle.IsVisible = false;
                ERDescription.IsVisible = false;

                // RName.IsVisible = true;
                RNum.IsVisible = true;
                RBNo.IsVisible = true;
                RDate.IsVisible = true;
                RTime.IsVisible = true;
                RTitle.IsVisible = true;
                RDescription.IsVisible = true;

                completeCloseRImage.IsVisible = false;
                editRImage.IsVisible = true;
                btnCompleteRConfirm.IsVisible = false;
            };
            completeCloseRImage.GestureRecognizers.Add(ClosetapGestureRecognizer);


        }



        private async Task btnCompleteRConfirm_ClickedAsync(object sender, EventArgs e)
        {
            // Navigation.PushAsync(new MasterPage (new ReminderPage()));


            // Navigation.PushAsync(new ReminderPageSelectedList(sender as ReminderModel));

            for (var counter = 1; counter < 1; counter++)
            {
                Navigation.RemovePage(Navigation.NavigationStack[Navigation.NavigationStack.Count]);
            }
            await Navigation.PopAsync();

        }
    }
}