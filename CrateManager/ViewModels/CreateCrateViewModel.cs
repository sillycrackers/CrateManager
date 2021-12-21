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
        private MainViewModel _mainViewModel;


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

        public ICommand AddCategoryCommand { get; set; }
        public ICommand AddNewCrateCommand { get; set; }

        public ObservableCollection<string> Categories { get; set; }

        public CreateCrateViewModel(MainViewModel mainVM)
        {
            AddCategoryCommand = new AddCategoryCommand(this);
            AddNewCrateCommand = new AddNewCrateCommand(this);

            Categories = new ObservableCollection<string>() {"Electrical", "Mechanical", "Miscellaneous"};

            
            _mainViewModel = mainVM;
        }

        public void ExecuteAddCategoryCommand(object parameter)
        {
            if (!Categories.Contains(parameter))
            {
                Categories.Add(parameter.ToString());
            }
        }

        public void ExecuteAddNewCrate()
        {
            if(!string.IsNullOrWhiteSpace(Name) && !string.IsNullOrWhiteSpace(Category) && !string.IsNullOrWhiteSpace(KeyItems))
            {
                _mainViewModel.CratesViewModel.AddNewCrate(_name, _category, _keyItems);
                _mainViewModel.SelectedViewModel = _mainViewModel.CratesViewModel;
            }
               
        }
    }
}
