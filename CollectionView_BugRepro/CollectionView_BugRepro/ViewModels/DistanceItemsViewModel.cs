using CollectionView_BugRepro.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CollectionView_BugRepro.ViewModels
{
    public class DistanceItemsViewModel : BaseViewModel
    {
        public bool IsLoaded { get; set; } = false;

        public Command LoadItemsCommand { get; }

        public ObservableCollection<Item> Items { get; }

        public DistanceItemsViewModel()
        {
            Items = new ObservableCollection<Item>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());

            IsLoaded = true;
        }


        public async Task ExecuteLoadItemsCommand()
        {
            IsBusy = true;

            try
            {
                Items.Clear();
                var items = await DataStore.GetMoreItemsAsync(true);

                foreach (var item in items)
                {
                    Items.Add(item);
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }

        public async Task ToggleSelectedUnitOfMeasurement()
        {
            if (!IsBusy)
            {
                await ExecuteLoadItemsCommand();
            }
        }


    }
}
