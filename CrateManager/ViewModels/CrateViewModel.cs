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
                OnPropertyChanged(Crate.ToString());
            }
        }
        public string test { get; set; } = "Hello World";

        public CrateViewModel()
        {
        }

        public CrateViewModel(Crate crate)
            : base()
        {
            Crate = crate;

            Crate.Items.Add(new CrateItem("Shoes"));
            Crate.Items.Add(new CrateItem("Wires"));
            Crate.Items.Add(new CrateItem("Pipes"));
            Crate.Items.Add(new CrateItem("Stacklights"));
            Crate.Items.Add(new CrateItem("Conduit"));
        }

    }
}
