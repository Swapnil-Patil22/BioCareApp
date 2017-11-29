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
    public partial class ContactPage : ContentPage
    {

        string defaultValue, defaultValue1, defaultValue2, defaultValue3, defaultValue4, defaultValue5, defaultValue6;
        public ContactPage()
        {
            InitializeComponent();

            defaultValue = entry_Fax.Text;

            defaultValue1 = entry_1.Text;



            defaultValue2 = entry2.Text;
            defaultValue3 = entry3.Text;
            defaultValue4 = entry4.Text;
            defaultValue5 = entry5.Text;
            defaultValue6 = entry6.Text;

        }


        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            (sender as Xamarin.Forms.Entry).Text = defaultValue;



        }

        private void Entry_TextChanged1(object sender, TextChangedEventArgs e)
        {

            (sender as Xamarin.Forms.Entry).Text = defaultValue1;
        }

        private void Entry_TextChanged2(object sender, TextChangedEventArgs e)
        {
            (sender as Xamarin.Forms.Entry).Text = defaultValue2;
        }

        private void Entry_TextChanged3(object sender, TextChangedEventArgs e)
        {
            (sender as Xamarin.Forms.Entry).Text = defaultValue3;
        }

        private void Entry_TextChanged4(object sender, TextChangedEventArgs e)
        {
            (sender as Xamarin.Forms.Entry).Text = defaultValue4;
        }

        private void Entry_TextChanged5(object sender, TextChangedEventArgs e)
        {
            (sender as Xamarin.Forms.Entry).Text = defaultValue5;
        }

        private void Entry_TextChanged6(object sender, TextChangedEventArgs e)
        {
            (sender as Xamarin.Forms.Entry).Text = defaultValue6;
        }
    }
}