using Calendario_Monica.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Calendario_Monica.Views
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