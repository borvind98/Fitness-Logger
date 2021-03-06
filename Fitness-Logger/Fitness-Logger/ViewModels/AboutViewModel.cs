using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Fitness_Logger.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://www.youtube.com/watch?v=xvFZjo5PgG0"));
        }

        public ICommand OpenWebCommand { get; }
    }
}