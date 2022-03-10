using CollectionView_BugRepro.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace CollectionView_BugRepro.Views
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