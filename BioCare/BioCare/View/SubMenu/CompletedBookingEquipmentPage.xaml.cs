using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BioCare.View.SubMenu
{
    public partial class CompletedBookingEquipmentPage : ContentPage
    {
        public CompletedBookingEquipmentPage()
        {
            InitializeComponent();
        }

        private void btnCancel_OnClicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void btnSubmit_OnClicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}
