using Mobile_App_V2.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Mobile_App_V2
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(Welcome), typeof(Welcome));
            Routing.RegisterRoute(nameof(UserProfile), typeof(UserProfile));
            Routing.RegisterRoute(nameof(Register), typeof(Register));
        }


    }
}
