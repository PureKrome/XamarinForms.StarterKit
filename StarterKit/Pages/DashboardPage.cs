using System;
using Xamarin.Forms;

namespace StarterKit
{
    public class DashboardPage : TabbedPage
    {
        public DashboardPage()
        {
            Children.Add(new ProfilePage());
            Children.Add(new AccountsPage());
            Children.Add(new WhateversPage());
        }
    }
}

