using System;
using Xamarin.Forms;

namespace StarterKit
{
    public class AuthenticationPage : ContentPage
    {
        private readonly NavigationPage _navigationPage;
        private readonly Configuration _configuration;

        public AuthenticationPage(NavigationPage navigationPage,
        Configuration configuration)
        {
            if (navigationPage == null)
            {
                throw new ArgumentNullException("navigationPage");
            }

            if (configuration == null)
            {
                throw new ArgumentNullException("configuration");
            }

            _navigationPage = navigationPage;
            _configuration = configuration;

            Title = "Sign In";
            BackgroundColor = new Color(46, 81, 163);
            Content = StackLayout;
        }

        private StackLayout StackLayout
        {
            get
            {
                var stackLayout = new StackLayout
                {
                    Spacing = 20,
                    Padding = 50,
                    VerticalOptions = LayoutOptions.Center
                };

                stackLayout.Children.Add(Header1);
                stackLayout.Children.Add(Header2);
                stackLayout.Children.Add(FacebookButton);
                stackLayout.Children.Add(GoogleButton);

                return stackLayout;
            }
        }

        private Label Header1 { get { return new Label{ Text = "Hello." }; } }

        private Label Header2 { get { return new Label{ Text = "Welcome to the StarterKit." }; } }

        private Button FacebookButton { get { return CreateLoginButton("Buttons/Login-Facebook.png"); } }

        private Button GoogleButton{ get { return CreateLoginButton("Buttons/Login-Google.png"); } }

        private Button CreateLoginButton(string fileName)
        {
            var button = new Button
            {
                Image = fileName
            };

            button.Clicked += async (object sender, EventArgs e) =>
            {
                     await _navigationPage.Navigation.PushModalAsync(new LoginPage());
           
            };
            
            return button;
        }
    }
}