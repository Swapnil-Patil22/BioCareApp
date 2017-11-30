using System;
using BioCare.Droid.Renderrer;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(Editor), typeof(EditorsRenderer))]
namespace BioCare.Droid.Renderrer
{
    public class EditorsRenderer : EditorRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Editor> e)
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
