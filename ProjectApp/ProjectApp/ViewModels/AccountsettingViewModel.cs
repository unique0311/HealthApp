using ProjectApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace ProjectApp.ViewModels
{
    public class AccountsettingViewModel : BaseViewModel
    {
        public Command AccountsetCommand { get; }
        public Command SignupGoingCommand { get; }

        public AccountsettingViewModel()
        {
            Title="Account-setting";
            AccountsetCommand = new Command(OnAccountsetClicked);
            SignupGoingCommand = new Command(OnSignupGoingClicked);
        }

        private async void OnAccountsetClicked(object obj)
        {
            // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
            await Shell.Current.GoToAsync($"//{nameof(AboutPage)}");
        }

        private async void OnSignupGoingClicked(object obj)
        {
            await Shell.Current.GoToAsync($"//{nameof(SignupPage)}");
        }
    }
}