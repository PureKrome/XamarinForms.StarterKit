using System;

using Xamarin.Forms;

namespace StarterKit
{
	public class App : Application
	{
        private readonly Configuration _configuration;

		public App (Configuration configuration)
		{
            if (configuration == null)
            {
                throw new ArgumentNullException("configuration");    
            }
            _configuration = configuration;

            var navigationPage = new NavigationPage();
            navigationPage.PushAsync(new AuthenticationPage(navigationPage, _configuration));

            MainPage = navigationPage;
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

