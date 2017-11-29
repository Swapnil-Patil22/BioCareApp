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
    public partial class EquipmentListPage : ContentPage
    {
        public EquipmentListPage()
        {
            //NavigationPage.SetHasNavigationBar(this, false);
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

        //protected override bool OnBackButtonPressed()
        //{
        //    base.OnBackButtonPressed();
        //   //App.Current.MainPage = (new MasterPage(new DashBoardPage()));
        //    return true;
        //}
    }
}