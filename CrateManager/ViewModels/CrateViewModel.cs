using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrateManager.Models;

namespace CrateManager.ViewModels
{
    public class CrateViewModel : BaseViewModel
    {

        private Crate _crate;

        public Crate Crate
        {
            get
            {
                return _crate;
            }
            set
            {
                _crate = value;
                OnPropertyChanged("Crate");
            }
        }
        public string test { get; set; } = "Hello World";

        public CrateViewModel()
        {
        }

        public CrateViewModel(Crate crate)
            : this()
        {
            Crate = crate;
        }

    }
}
