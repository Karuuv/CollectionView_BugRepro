using CollectionView_BugRepro.ViewModels;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CollectionView_BugRepro.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CellReuseBugPage : ContentPage
    {
        CellReuseBugViewModel viewModel;

        public CellReuseBugPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new CellReuseBugViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        private async void ToggleMeasurementUnits_Clicked(object sender, EventArgs e)
        {
            viewModel.ToggleSelectedUnitOfMeasurement();
            await DistanceItemsView.ToggleUnitOfMeasurement_Clicked();
        }
    }
}