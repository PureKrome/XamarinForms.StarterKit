using System;
using Xamarin.Forms.Platform.iOS;
using Xamarin.Forms;
using Xamarin.Auth;
using StarterKit;
using StarterKit.iOS;

[assembly: ExportRenderer (typeof (LoginPage), typeof (LoginPageRenderer))]

namespace StarterKit.iOS
{
    public class LoginPageRenderer : PageRenderer
	{
        private bool _isShown;

		public override void ViewDidAppear (bool animated)
        {
            // BUG: ViewDidAppear keeps getting called, crashing in a Stack Overflow.
            //      Why is this getting called?
            ViewDidAppear(animated);

            var i = 0;

            if (!_isShown)
            {
                _isShown = true;

                // TODO: Replace with a CONFIGURATION class instance one I learn how to pass instances, into
                //       a custom renderer.
                var auth = new OAuth2Authenticator(
                    clientId: "some-client-id",
                    scope: "",
                    authorizeUrl: new Uri("https://m.facebook.com/dialog/oauth/"),
                    redirectUrl: new Uri("http://www.facebook.com/connect/login_success.html"));

                auth.Completed += (sender, eventArgs) =>
                {
                    DismissViewController(true, null);
                    if (eventArgs.IsAuthenticated)
                    {
                        //App.SaveToken(eventArgs.Account.Properties["access_token"]);
                    }
                    else
                    {
                        // The user cancelled
                    }
                };

                PresentViewController(auth.GetUI(), true, null);
            }
        }
	}
}

