using System;
using Xamarin.Forms;

namespace StarterKit
{
	public class AccountsPage : ContentPage
	{
		public AccountsPage ()
		{
			Title = "Accounts";
			Icon = "TabIcons/About.png";
			Content = new StackLayout {
				BackgroundColor = new Color(46, 81, 163),
				VerticalOptions = LayoutOptions.Center,
				Children = {
					new Label {
						XAlign = TextAlignment.Center,
						Text = "Accounts"
					}
				}
			};
		}
	}
}

