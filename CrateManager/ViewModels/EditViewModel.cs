﻿using CrateManager.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CrateManager.ViewModels
{
    public class EditViewModel : BaseViewModel
    {
        
        private string _name;
        private string _category;
        private string _keyItems;
        private MainViewModel _mainViewModel;
        private Crate _selectedCrate;

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

        [JsonIgnore]
        public ICommand AddCategoryCommand { get; set; }
        [JsonIgnore]
        public ICommand AddNewCrateCommand { get; set; }

        public ObservableCollection<string> Categories { get; set; }

        public EditViewModel()
        {
            _selectedCrate = new Crate();
        }

        public EditViewModel(MainViewModel mainVM) : base()
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
