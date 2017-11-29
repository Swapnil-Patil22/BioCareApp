using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ImageCircle.Forms;
using Plugin.FilePicker.Abstractions;
using Plugin.FilePicker;
using BioCare.Model;
using ImageCircle.Forms.Plugin.Abstractions;

namespace BioCare.View.SubMenu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfilePage : ContentPage
    {
        
        public ProfilePage()
        { 
            InitializeComponent();

            bool galleryedit = false;

            // NavigationPage.SetTitleIcon(this, "play.png");

            TapGestureRecognizer recognizer = new TapGestureRecognizer();
            recognizer.Tapped += async (sender2, args) =>
            {
                    FileData fileData = new FileData();
                    FileData filedata = null;
                    try
                    {
                        filedata = await CrossFilePicker.Current.PickFile();
                        if (!string.IsNullOrEmpty(filedata.FileName)) //Just the file name, it doesn't has the path
                        {

                            byte[] bydata = filedata.DataArray;
                            String UploadData = Convert.ToBase64String(bydata);

                            var stream = new MemoryStream(bydata);
                            ProfileImage.Source = ImageSource.FromStream(() => stream);

                            GalleryBigImg.IsVisible = false;
                            closeImage.IsVisible = true;

                        }
                    }

                    catch (Exception ex)
                    {
                        filedata = null;
                        System.Diagnostics.Debug.WriteLine("Warning Exception :  " + ex.Message);
                    }
            };

            GalleryBigImg.GestureRecognizers.Add(recognizer);


            TapGestureRecognizer profileImagrecognizer = new TapGestureRecognizer();
            profileImagrecognizer.Tapped += async (sender2, args) =>
            {
                if (galleryedit == true)
                {


                    FileData fileData = new FileData();
                    FileData filedata = null;


                    try
                    {
                        filedata = await CrossFilePicker.Current.PickFile();
                        if (!string.IsNullOrEmpty(filedata.FileName)) //Just the file name, it doesn't has the path
                        {
                             byte[] bydata = filedata.DataArray;
                            String UploadData = Convert.ToBase64String(bydata);
                            var stream = new MemoryStream(bydata);
                            ProfileImage.Source = ImageSource.FromStream(() => stream);

                            GalleryBigImg.IsVisible = false;
                            closeImage.IsVisible = true;
                        }
                    }


                    catch (Exception ex)
                    {
                        filedata = null;
                        System.Diagnostics.Debug.WriteLine("Warning Exception :  " + ex.Message);
                    }
                }

                else
                {

                }

            };

            ProfileImage.GestureRecognizers.Add(profileImagrecognizer);

            var editImgRecognizer = new TapGestureRecognizer();
            editImgRecognizer.Tapped += (s, e) => {
                // handle the tap              

                galleryedit = true;

                GalleryBigImg.IsVisible = true;
                btnConfirm.IsVisible = true;
                closeImage.IsVisible = true;
                EName.IsEnabled = true;
                EEmail.IsEnabled = true;
                EUser.IsEnabled = true;
                PenEditImg.IsVisible = false;

            };
            PenEditImg.GestureRecognizers.Add(editImgRecognizer);

            var tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += (s, e) => {
                // handle the tap
                GalleryBigImg.IsVisible = false;
                btnConfirm.IsVisible = false;
                closeImage.IsVisible = true;
                // btnEdit.IsVisible = true;

                App.Current.MainPage = new MasterPage(new ProfilePage());
            };
            closeImage.GestureRecognizers.Add(tapGestureRecognizer);

        }

        //private void EditProfileButton_OnClicked(object sender, EventArgs e)
        //{
        //    btnEdit.IsVisible = false;
        //    SettingImg.IsVisible = true;
        //    btnConfirm.IsVisible = true;
        //    closeImage.IsVisible = true;

        //}

        private void EditProfileConfirm_OnClicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new MasterPage(new ProfilePage());
        }

        //private void EditProfileCancel_OnClicked(object sender, EventArgs e)
        //{
        //    SettingImg.IsVisible = false;
        //    btnConfirm.IsVisible = false;
        //   // btnEdit.IsVisible = true;

        //}

    }
}