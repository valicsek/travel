using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

using Foundation;
using UIKit;
using Plugin.Media;

namespace Travel.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();
            Xamarin.FormsMaps.Init();
            CrossMedia.Current.Initialize();

            LoadApplication(new App(Config.databasePath));
            this.setupView();
            return base.FinishedLaunching(app, options);
        }

        private void setupView()
        {
            UIColor tintColor = UIColor.White;
            UIColor navigationBarColor = UIColor.FromRGB(236,67,48);
            UINavigationBar.Appearance.BarTintColor = navigationBarColor;
            UINavigationBar.Appearance.TintColor = tintColor;
            UINavigationBar.Appearance.TitleTextAttributes = new UIStringAttributes() { ForegroundColor = UIColor.White };
            UINavigationBar.Appearance.Translucent = false;
        }
    }
}
