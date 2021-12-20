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


        private string _name;
        private int _id;
        private string _category;

        public string Category
        {
            get
            {
                if (String.IsNullOrWhiteSpace(_category))
                {
                    return "NoCategory";
                }
                return _category;
            }
            set
            {
                _category = value;
                OnPropertyChanged("Category");
            }
        }
        public string Name
        {
            get
            {
                if (String.IsNullOrWhiteSpace(_name))
                {
                    return "NoName";
                }
                return _name;

            }
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }
        public int ID
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
                OnPropertyChanged("ID");
            }
        }

        public Crate()
        {
            Items = new ObservableCollection<CrateItem>();
        }

        public Crate(int id) : this()
        {
            ID = id;
        }

        public Crate(string name, string category, int id) : this()
        {
            Name = name;
            Category = category;
            ID = id;

        }

        public override string ToString()
        {
            return this.Name;
        }

    }
}
