using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SettingPage : ContentPage
    {
        public SettingPage()
        {
            InitializeComponent();
            BindingContext = new SettingViewModel();
        }
    }
}