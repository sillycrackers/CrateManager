using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrateManager.Models
{
    

    public class Crate : ObservableObject
    {
        public ObservableCollection<CrateItem> Items { get; set; }

        
        
        public Crate()
        {
            Items = new ObservableCollection<CrateItem>();
        }

    }
}
