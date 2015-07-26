using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace StarterKit.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();

            // Code for starting up the Xamarin Test Cloud Agent
            #if ENABLE_TEST_CLOUD
            Xamarin.Calabash.Start();
            #endif

            // Load the configuration settings.
            var configuration = new Configuration();
            configuration.FacebookSettings = new OAuthSettings();
            configuration.GoogleSettings = new OAuthSettings();


            LoadApplication(new App(configuration));

            return base.FinishedLaunching(app, options);
        }

        private OAuthSettings LoadFacebookSettings()
        {
            var facebookSettings = new OAuthSettings
            {
                Scopes = "", 
                AuthorizeUrl = "https://m.facebook.com/dialog/oauth/",
                RedirectUrl = "http://www.facebook.com/connect/login_success.html"
            };

            return facebookSettings;
        }

        private OAuthSettings LoadGoogleSettings()
        {
            var googleSettings = new OAuthSettings
                {
                    Scopes = "", 
                    AuthorizeUrl = "todo",
                    RedirectUrl = "todo"
                };

            return googleSettings;
        }
    }
}

