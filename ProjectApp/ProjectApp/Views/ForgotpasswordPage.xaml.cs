using ProjectApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ForgotpasswordPage : ContentPage
    {
        public ForgotpasswordPage()
        {
            InitializeComponent();
            this.BindingContext = new ForgotpasswordViewModel();
        }
    }
}