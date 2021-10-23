using System.ComponentModel;
using Fitness_Logger.ViewModels;
using Xamarin.Forms;

namespace Fitness_Logger.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}