using CrateManager.Models;
using System.Collections.ObjectModel;


namespace CrateManager.ViewModels
{
    public class CrateViewModel : ObservableObject
    {
        public ObservableCollection<CrateItem> Items { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set 
            { 
                _currentView = value;
            }
        }


        public CrateViewModel()
        {
            Items = new ObservableCollection<CrateItem>();
        }

    }
}
