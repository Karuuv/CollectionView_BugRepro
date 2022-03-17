using CollectionView_BugRepro.ViewModels;
using System.Threading.Tasks;
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

        public async Task ToggleUnitOfMeasurement_Clicked()
        {
            await viewModel.ToggleSelectedUnitOfMeasurement();
        }

        public async Task RefreshData()
        {
            await viewModel.ExecuteLoadItemsCommand();
        }

        public void OnAppearing()
        {
            _ = viewModel.ExecuteLoadItemsCommand();
        }

    }
}