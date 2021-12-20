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
                if(value > 0)
                {
                    _quantity = value;
                    OnPropertyChanged("Quantity");
                }
            }
        }
        public string Description
        {
            get {
                if (!string.IsNullOrWhiteSpace(_description))
                {
                    return _description;
                }
                return "Empty";
            }
            set
            {
                _description = value;
                OnPropertyChanged("Description");
            }
        }
        public string PartNumber
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(_partNumber))
                {
                    return _partNumber;
                }
                return "";
            }
            set
            {
                _partNumber = value;
                OnPropertyChanged("PartNumber");
            }
        }

        private string _description;
        private string _name;
        private int _quantity;
        private string _partNumber;

        public CrateItem(string name)
        {
            Name = name;
        }

    }
}
