using ProjectApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace ProjectApp.ViewModels
{
    public class ForgotpasswordViewModel : BaseViewModel
    {
        public Command ForgotpasswordCommand { get; }

        public ForgotpasswordViewModel()
        {
            ForgotpasswordCommand = new Command(OnForgotpasswordClicked);
        }

        private async void OnForgotpasswordClicked(object obj)
        {
            // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
            await Shell.Current.GoToAsync($"//{nameof(SignupPage)}");
        }
    }
}