using CollectionView_BugRepro.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CollectionView_BugRepro.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CellReuseBugPage : ContentPage
    {
        CellReuseBugViewModel _viewModel;

        public CellReuseBugPage()
        {
            InitializeComponent();

            BindingContext = _viewModel = new CellReuseBugViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}