using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrateManager.ViewModels
{
    public class CreateCrateViewModel : BaseViewModel
    {
        
        private string _name;
        private string _category;
        private string _keyItems;


        public string KeyItems
        {
            get 
            { 
                return _keyItems; 
            }
            set 
            { 
                _keyItems = value;
                OnPropertyChanged("KeyItems");
            }
        }
        public string Category
        {
            get 
            { 
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
                return _name; 
            }
            set 
            { 
                _name = value;
                OnPropertyChanged("Name");
            }
        }

        public ObservableCollection<string> Categories;

        public CreateCrateViewModel()
        {
            Categories = new ObservableCollection<string>() {"Electrical", "Mechanical", "Automation", "Miscellaneous"};

        }
    }
}
