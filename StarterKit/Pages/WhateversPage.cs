using System;
using Xamarin.Forms;

namespace StarterKit
{
    public class WhateversPage : ContentPage
	{
        public WhateversPage ()
		{
			Title = "Whatevers";
			Icon = "TabIcons/Payments.png";
			Content = new StackLayout {
				BackgroundColor = new Color (46, 81, 163),
				VerticalOptions = LayoutOptions.Center,
				Children = {
					new Label {
						XAlign = TextAlignment.Center,
						Text = "Whatevers Page"
					}
				}
			};
		}
	}
}

