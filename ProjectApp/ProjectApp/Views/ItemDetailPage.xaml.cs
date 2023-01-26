using ProjectApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace ProjectApp.Views
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