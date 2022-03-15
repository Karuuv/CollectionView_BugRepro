using CollectionView_BugRepro.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CollectionView_BugRepro.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DistanceItemsView : ContentView
    {
        DistanceItemsViewModel viewModel;
        public DistanceItemsView()
        {
            InitializeComponent();

            BindingContext = viewModel = new DistanceItemsViewModel();
            viewModel.ExecuteLoadItemsCommand();
        }


        public async void ToggleUnitOfMeasurement_Clicked()
        {
            await viewModel.ToggleSelectedUnitOfMeasurement();
        }

    }
}