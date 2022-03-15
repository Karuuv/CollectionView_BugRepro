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
            viewModel.OnAppearing();
        }

        private void ReproStepsItem_Clicked(object sender, System.EventArgs e)
        {
            Application.Current.MainPage.DisplayAlert("Reproduction Steps",
                                                      "Bug only for iOS." + Environment.NewLine + Environment.NewLine +
                                                      "Tap the \"Switch Units\" button - it works fine on first click." + Environment.NewLine +
                                                      "Tap it a second time, odds are this time it didn't actually shift." + Environment.NewLine +
                                                      "Pulling down to refresh can either set it to the correct state, or flip it.",
                                                      "Ok");
        }

        private async void ToggleMeasurementUnits_Clicked(object sender, EventArgs e)
        {
            await viewModel.ToggleSelectedUnitOfMeasurement();
            DistanceItemsView.ToggleUnitOfMeasurement_Clicked();
        }
    }
}