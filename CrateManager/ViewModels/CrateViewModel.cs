using CrateManager.Models;
using System.Collections.ObjectModel;


namespace CrateManager.ViewModels
{
    public class CrateViewModel : ObservableObject
    {
        public ObservableCollection<CrateItem> Items { get; set; }

        public CrateViewModel()
        {
            Items = new ObservableCollection<CrateItem>();
        }

    }
}
