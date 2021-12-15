using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrateManager.Models
{
    public class CrateItem : ObservableObject
    {
        public string Name {
            get
            {
                if (String.IsNullOrWhiteSpace(_name))
                {
                    return "No name";
                }
                return _name;
            }
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }
        public int Quantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                if(value < 0)
                {
                    _quantity = value;
                }
            }
        }

        private string _name;
        private int _quantity;
        
        public CrateItem(string name)
        {
            Name = name;
        }

    }
}
