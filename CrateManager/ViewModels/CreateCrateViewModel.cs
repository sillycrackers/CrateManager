using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

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
        public string Test { get; set; }

        public ICommand AddCategoryCommand { get; set; }

        public ObservableCollection<string> Categories { get; set; }

        public CreateCrateViewModel()
        {
            AddCategoryCommand = new AddCategoryCommand(this);
            Categories = new ObservableCollection<string>();
            Test = "This is a test";
        }

        public void ExecuteAddCategoryCommand(object parameter)
        {
            if (!Categories.Contains(parameter))
            {
                Categories.Add(parameter.ToString());
            }
            
        }
    }
}
