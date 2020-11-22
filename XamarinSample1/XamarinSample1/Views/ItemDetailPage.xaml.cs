using System.ComponentModel;
using Xamarin.Forms;
using XamarinSample1.ViewModels;

namespace XamarinSample1.Views
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