using CollectionView_BugRepro.Models;
using CollectionView_BugRepro.Services;
using Xamarin.Forms;

namespace CollectionView_BugRepro
{
    public partial class App : Application
    {
        public static LocalUserPreferences LocalPreferences { get; set; } = new LocalUserPreferences();

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
