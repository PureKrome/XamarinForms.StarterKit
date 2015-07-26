using System;
using Xamarin.Forms;

namespace StarterKit
{
	public class ProfilePage : ContentPage
	{
		public ProfilePage()
		{
			Title = "Profile";
			Icon = "TabIcons/Contacts.png";
			Content = new StackLayout {
				BackgroundColor = new Color(46, 81, 163),
				VerticalOptions = LayoutOptions.Center,
				Children = {
					new Label {
						XAlign = TextAlignment.Center,
						Text = "Profile"
					}
				}
			};
		}
	}
}