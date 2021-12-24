using CrateManager.Models;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text.Json.Serialization;
using System.Windows.Input;

namespace CrateManager.ViewModels
{
    public class EditViewModel : BaseViewModel
    {
        
        private string _name;
        private string _category;
        private string _keyItems;
        private string _newName;
        private string _newCategory;
        private string _newKeyItems;
        private MainViewModel _mainViewModel;
        private Crate _selectedCrate;
        private bool _itemSelected;

        public Crate SelectedCrate
        {
            get
            {
                return _selectedCrate;
            }
            set
            {
                _selectedCrate = value;
                OnPropertyChanged("SelectedCrate");
            }
        }
        
        public MainViewModel MainViewModel
        {
            get
            {
                return _mainViewModel;
            }
            set
            {
                _mainViewModel = value;
                OnPropertyChanged("MainViewModel");
            }
        }
        public string NewName
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_newName))
                {
                    return "";
                }
                return _newName;
            }
            set
            {
                _newName = value;
                OnPropertyChanged("NewName");
            }
        }
        public string NewKeyItems
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_newKeyItems))
                {
                    return "";
                }
                return _newKeyItems;
            }
            set
            {
                _newKeyItems = value;
                OnPropertyChanged("NewKeyItems");
            }
        }
        public string NewCategory
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_newCategory))
                {
                    return "";
                }
                return _newCategory;
            }
            set
            {
                _newCategory = value;
                OnPropertyChanged("NewCategory");
            }
        }
        public string KeyItems
        {
            get 
            {
                if (string.IsNullOrWhiteSpace(_keyItems))
                {
                    return "";
                }
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
                if (string.IsNullOrWhiteSpace(_category))
                {
                    return "";
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
                if (string.IsNullOrWhiteSpace(_name))
                {
                    return "";
                }
                return _name; 
            }
            set 
            { 
                _name = value;
                OnPropertyChanged("Name");
            }
        }
        public bool ItemSelected
        {
            get
            {
                return _itemSelected;
            }
            set
            {
                _itemSelected = value;
                OnPropertyChanged("ItemSelected");
            }
        }

        [JsonIgnore]
        public ICommand AddCategoryCommand { get; set; }
        [JsonIgnore]
        public ICommand AddNewCrateCommand { get; set; }
        [JsonIgnore]
        public ICommand UpdateCrateCommand { get; set; }
        [JsonIgnore]
        public ICommand CrateSelectedChangedCommand { get; set; }

        public ObservableCollection<string> Categories { get; set; }

        public EditViewModel()
        {
            _selectedCrate = new Crate();
        }

        public EditViewModel(MainViewModel mainVM) : base()
        {
            AddCategoryCommand = new AddCategoryCommand(this);
            AddNewCrateCommand = new AddNewCrateCommand(this);
            UpdateCrateCommand = new UpdateCrateCommand(this);
            CrateSelectedChangedCommand = new CrateSelectedChangedCommand(this);

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
            if(!string.IsNullOrWhiteSpace(_name) && !string.IsNullOrWhiteSpace(_category) && !string.IsNullOrWhiteSpace(_keyItems))
            {
                _mainViewModel.CratesViewModel.AddNewCrate(_name, _category, _keyItems);
                _mainViewModel.SelectedViewModel = _mainViewModel.CratesViewModel;
            }
               
        }

        public void ExecuteUpdateCrate()
        {
            if (!string.IsNullOrWhiteSpace(_newName) && !string.IsNullOrWhiteSpace(_newCategory) && !string.IsNullOrWhiteSpace(_newKeyItems))
            {

                Crate result = _mainViewModel.CratesViewModel.Crates.FirstOrDefault(x => x.Name == SelectedCrate.Name);

                result.Name = _newName;
                result.Category = _newCategory;
                result.KeyItems = _newKeyItems;
            }
        }

        public void ExecuteCrateSelectedChanged()
        {
            if(SelectedCrate != null)
            {
                NewName = SelectedCrate.Name;
                NewCategory = SelectedCrate.Category;
                NewKeyItems = SelectedCrate.KeyItems;
                ItemSelected = true;
            }
            
        }
    }
}
