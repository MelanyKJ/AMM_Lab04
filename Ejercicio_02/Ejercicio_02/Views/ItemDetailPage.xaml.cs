using Ejercicio_02.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Ejercicio_02.Views
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