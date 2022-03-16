using CollectionView_BugRepro.Models;
using CollectionView_BugRepro.Views;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CollectionView_BugRepro.ViewModels
{
    public class CellReuseBugViewModel : BaseViewModel
    {
        public bool IsLoaded { get; set; } = false;

        public string MeasurementUnitType
        {
            get
            {
                if (App.LocalPreferences.UserDistanceUnit == LocalUserPreferences.DistanceUnit.Yards)
                {
                    return "Imperial";
                }
                else
                {
                    return "Metric";
                }
            }
        }


        public CellReuseBugViewModel()
        {
            Title = "CollectionView Cell Reuse Bug";
            IsLoaded = true;
        }

        public void ToggleSelectedUnitOfMeasurement()
        {
            if (!IsBusy)
            {
                App.LocalPreferences.UserDistanceUnit = App.LocalPreferences.UserDistanceUnit == LocalUserPreferences.DistanceUnit.Yards ? LocalUserPreferences.DistanceUnit.Meters : LocalUserPreferences.DistanceUnit.Yards;
                OnPropertyChanged("MeasurementUnitType");
            }
        }

    }
}