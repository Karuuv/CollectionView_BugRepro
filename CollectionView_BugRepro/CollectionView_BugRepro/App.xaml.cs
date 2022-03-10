using CollectionView_BugRepro.Services;
using CollectionView_BugRepro.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CollectionView_BugRepro
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
