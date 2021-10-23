using System;
using System.Collections.Generic;
using System.ComponentModel;
using Fitness_Logger.Models;
using Fitness_Logger.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Fitness_Logger.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}