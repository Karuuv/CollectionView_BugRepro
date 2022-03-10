using CollectionView_BugRepro.ViewModels;
using CollectionView_BugRepro.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace CollectionView_BugRepro
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
