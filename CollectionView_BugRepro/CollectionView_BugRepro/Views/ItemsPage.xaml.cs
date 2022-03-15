using CollectionView_BugRepro.ViewModels;
using System;
using Xamarin.Forms;

namespace CollectionView_BugRepro.Views
{
    public partial class ItemsPage : ContentPage
    {
        ItemsViewModel _viewModel;

        public ItemsPage()
        {
            InitializeComponent();

            BindingContext = _viewModel = new ItemsViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
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
    }
}