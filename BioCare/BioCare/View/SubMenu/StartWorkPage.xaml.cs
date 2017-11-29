using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.ComponentModel;
using BioCare.View;
using BioCare.View.PopUpPages;
using Rg.Plugins.Popup.Services;

namespace BioCare.View.SubMenu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StartWorkPage : ContentPage
    {
        private bool _isRunning;
        string startValue = null;
        string answer = null;
        TimeSpan startTimeSpan;
        TimeSpan endTimeSpan;

        System.Diagnostics.Stopwatch myStopWatch = new System.Diagnostics.Stopwatch();

        public void EnableTimer()
        {
            Device.StartTimer(TimeSpan.FromMilliseconds(1), () =>
            {
                endTimeSpan = myStopWatch.Elapsed;
                answer = string.Format("{0:D2} {1:D2} {2:D2}",
                                   endTimeSpan.Hours,
                                   endTimeSpan.Minutes,
                                   endTimeSpan.Seconds,
                                   endTimeSpan.Milliseconds);
                if (answer != null)
                {
                    segmentSevenGauge.Value = answer;
                }
                return _isRunning;

            });
        }

        public StartWorkPage()
        {
            InitializeComponent();
            segmentSevenGauge.BackgroundColor = Color.White;
            segmentSevenGauge.CharacterStrokeColor = Color.FromHex("#0E197C");
            segmentSevenGauge.HeightRequest = 50;
            valueSettings();

            bool isRestartTime = false;
            bool isPauseTime = false;

            DateTime dt = DateTime.Now;
            String fixedStartTime = "";

            fixedStartTime = dt.ToString("HH : mm : ss MM/dd/yyyy");




            var PlayRecognizer = new TapGestureRecognizer();
            PlayRecognizer.Tapped += (s, e) => {
                // handle the tap
                PauseImg.IsVisible = true;
                PlayImg.IsVisible = false;
                ResetImg.IsVisible = false;
                StopImg.IsVisible = false;
                btnDone.IsVisible = false;

                _isRunning = true;
                myStopWatch.Start();
                startTimeSpan = myStopWatch.Elapsed;

                var Totaltime = endTimeSpan - startTimeSpan;

                startValue = string.Format("{0:D2} {1:D2} {2:D2}",
                                startTimeSpan.Hours,
                                startTimeSpan.Minutes,
                                startTimeSpan.Seconds,
                                startTimeSpan.Milliseconds);




                if (isRestartTime == true && Startime.Text == null)
                {
                    DateTime dt1 = DateTime.Now;
                    String RestartTime = "";

                    RestartTime = dt1.ToString("HH : mm :ss MM/dd/yyyy");

                    //  string fixedRestartTime = RestartTime.Text;

                    Startime.Text = RestartTime;




                    //if (isRestartTime == true && isPauseTime == true)
                    //{


                    //}
                    //  string PT = Startime.Text;

                    //if (isPauseTime == true && isRestartTime == true)
                    // {
                    //     Startime.Text = Startime.Text;
                    // }//



                }


                else if (isRestartTime == true && Startime.Text != null)
                {
                    Startime.Text = Startime.Text;
                    //  isRestartTime = false;
                }


                else if (Startime.Text == null)
                    Startime.Text = fixedStartTime.ToString();
                else if (isPauseTime == true)
                {
                    //DateTime dt1 = DateTime.Now;
                    //String Pause = "";

                    //Pause = dt1.ToString("HH : mm :ss MM/dd/yyyy");

                    // startValue = answer;
                    Startime.Text = fixedStartTime.ToString();

                }



                else
                {

                }


                TotalTime.Text = "";
                EnableTimer();



            };
            PlayImg.GestureRecognizers.Add(PlayRecognizer);

            var PauseRecognizer = new TapGestureRecognizer();
            PauseRecognizer.Tapped += (s, e) => {
                // handle the tap
                PauseImg.IsVisible = false;
                PlayImg.IsVisible = true;
                ResetImg.IsVisible = true;
                StopImg.IsVisible = true;

                _isRunning = false;
                myStopWatch.Stop();

                EndTime.Text = answer;

                var Totaltime = endTimeSpan - startTimeSpan;
                var Total = string.Format("{0:D2} {1:D2} {2:D2}",
                                               Totaltime.Hours,
                                               Totaltime.Minutes,
                                               Totaltime.Seconds,
                                               Totaltime.Milliseconds);

                TotalTime.Text = answer;

                DateTime dt3 = DateTime.Now;
                String EndTimePause = "";

                EndTimePause = dt3.ToString("HH : mm : ss MM/dd/yyyy");

                EndTime.Text = EndTimePause.ToString();

                isPauseTime = true;


            };
            PauseImg.GestureRecognizers.Add(PauseRecognizer);


            var ResetRecognizer = new TapGestureRecognizer();
            ResetRecognizer.Tapped += (s, e) => {
                // handle the tap
                PauseImg.IsVisible = false;
                PlayImg.IsVisible = true;
                ResetImg.IsVisible = false;
                StopImg.IsVisible = false;

                //DateTime dt1 = DateTime.Now;
                //String RestartTime = "";

                //RestartTime = dt1.ToString("HH : mm :ss MM/dd/yyyy");

                myStopWatch = new System.Diagnostics.Stopwatch();
                EndTime.Text = "";
                Startime.Text = null;
                answer = null;
                segmentSevenGauge.Value = "00 00 00";
                TotalTime.Text = "";

                isRestartTime = true;

            };
            ResetImg.GestureRecognizers.Add(ResetRecognizer);


            var StopRecognizer = new TapGestureRecognizer();
            StopRecognizer.Tapped += async (s, e) =>
            {
                // handle the tap
                PauseImg.IsVisible = false;
                PlayImg.IsVisible = false;
                ResetImg.IsVisible = false;
                StopImg.IsVisible = false;

                _isRunning = false;
                myStopWatch.Stop();

                DateTime dt3 = DateTime.Now;
                String EndTimeStop = "";

                EndTimeStop = dt3.ToString("HH : mm : ss MM/dd/yyyy");

                EndTime.Text = EndTimeStop.ToString();

                var Totaltime = endTimeSpan - startTimeSpan;
                var Total = string.Format("{0:D2}: {1:D2}: {2:D2}",
                                               Totaltime.Hours,
                                               Totaltime.Minutes,
                                               Totaltime.Seconds,
                                               Totaltime.Milliseconds);
                TotalTime.Text = answer;

                var alertResult = new StopWorkAlert();
                await PopupNavigation.PushAsync(alertResult);
                PlayImg.IsVisible = true;


                //var alertResult = await DisplayAlert("Confirm", "Are you sure you want to stop work?", "CANCEL", "OK");
                //if (!alertResult)
                //{
                //     App.Current.MainPage = new NavigationPage(new StartWorkPage());

                //    StopImg.GestureRecognizers.Add(StopRecognizer);
                //    btnDone.IsVisible = true;
                //}

                //else
                //{
                //    PlayImg.IsVisible = true;
                //}

            };
            StopImg.GestureRecognizers.Add(StopRecognizer);

            MessagingCenter.Subscribe<StopWorkAlert>(this, "OkButtonClicked", (sender) => {
                PlayImg.IsVisible = true;
                //segmentSevenGauge.Value = "00 00 00";
                //Startime.Text = null;
                //EndTime.Text = null;
                //TotalTime.Text = "";
                btnDone.IsVisible = true;
            });
        }

        public void valueSettings()
        {
            if (Device.OS == TargetPlatform.iOS)
            {
                segmentSevenGauge.WidthRequest = (8 * segmentSevenGauge.CharacterWidth) + (8 * segmentSevenGauge.CharacterSpacing);
            }
            EnableTimer();

            if (Device.OS == TargetPlatform.Android)
            {
                segmentSevenGauge.HeightRequest = segmentSevenGauge.CharacterHeight + segmentSevenGauge.CharacterHeight / 6;

            }
            if (Device.OS == TargetPlatform.WinPhone || Device.OS == TargetPlatform.Windows)
            {
                segmentSevenGauge.HeightRequest = 65;
                segmentSevenGauge.CharacterHeight = 65;
                segmentSevenGauge.CharacterWidth = 20;
                segmentSevenGauge.SegmentStrokeWidth = 3;
                segmentSevenGauge.WidthRequest = 350;
                segmentSevenGauge.HorizontalOptions = LayoutOptions.Center;
                MainGrid.BackgroundColor = Color.White;
            }

        }

        private void FeedbackBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FeedbackPage());

            // App.Current.MainPage = new MasterPage(new TabbedPage2());
        }

    }
}