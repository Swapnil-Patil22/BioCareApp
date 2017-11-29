using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using BioCare;
using BioCare.Droid;

[assembly: ExportRenderer(typeof(CustomEntry1), typeof(CustomEntryRenderer1))]
namespace BioCare.Droid
{
    public class CustomEntryRenderer1 : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);


            if (Control != null)
            {
                //GradientDrawable gd = new GradientDrawable();
                //gd.SetColor(global::Android.Graphics.Color.Transparent);
                //this.Control.SetBackgroundDrawable(gd);
                //this.Control.SetRawInputType(InputTypes.TextFlagNoSuggestions);
                //Control.SetHintTextColor(ColorStateList.ValueOf(global::Android.Graphics.Color.White));

                // this.Control.InputType = InputTypes.TextFlagNoSuggestions;

                Control.SetBackgroundColor(Android.Graphics.Color.Argb(0, 0, 0, 0));
                //  Control.ShowSoftInputOnFocus = false;

            }

        }
    }
}