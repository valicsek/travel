using System;
using System.Collections.Generic;
using Plugin.Media;
using Xamarin.Forms;

namespace Travel
{
    public partial class CameraPage : ContentPage
    {
        public CameraPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            await CrossMedia.Current.Initialize();

            if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsPickPhotoSupported )
            {
                await DisplayAlert("Alert", "The camera is not available", "OK");
                return;
            }
            else
            {
                try
                {
                    var file = await CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions {
                        DefaultCamera = Plugin.Media.Abstractions.CameraDevice.Front,
                        SaveToAlbum = false
                    });

                    if (file == null) return;

                    CameraImage.Source = ImageSource.FromStream(() => {
                        var stream = file.GetStream();
                        file.Dispose();
                        return stream;
                    });
                } catch (Exception e) {
                   await DisplayAlert("Error", e.Message, "OK");
                }
            }
        }

        async void OnButtonTakePhotoClicked(object sender, System.EventArgs e)
        {
            if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
            {
                await DisplayAlert("Alert", "The camera is not available", "OK");
                return;
            }
        }

        async void OnButtonTakeVideoClicked(object sender, System.EventArgs e)
        {
            if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakeVideoSupported)
            {
                await DisplayAlert("Alert", "The camera is not available", "OK");
                return;
            }
        }
    }
}
