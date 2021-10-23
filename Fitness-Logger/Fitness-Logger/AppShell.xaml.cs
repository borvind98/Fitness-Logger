using System;
using System.Collections.Generic;
using Fitness_Logger.ViewModels;
using Fitness_Logger.Views;
using Xamarin.Forms;

namespace Fitness_Logger
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
