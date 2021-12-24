using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using System.Windows;
using CrateManager.Models;
using System.Windows.Input;
using System.Linq;

namespace CrateManager.ViewModels
{ 
    public class MainViewModel : BaseViewModel
    {
        private BaseViewModel _selectedViewModel;
        private CratesViewModel _cratesViewModel;
        private CrateViewModel _crateViewModel;
        private ObservableCollection<string> _searchResults;

        public ObservableCollection<string> SearchResults
        {
            get { return _searchResults; }
            set { _searchResults = value; OnPropertyChanged("SearchResults"); }
        }
        public string CopyrightSymbol { get; set; } = "\u00A9";
        public CratesViewModel CratesViewModel {
            get
            {
                return _cratesViewModel;
            }

            set
            {
                _cratesViewModel = value;
                OnPropertyChanged("CratesViewModel");
            }
            }
        public CrateViewModel CrateViewModel {
            get
            {
                return _crateViewModel;
            }
            set
            {
                _crateViewModel = value;
                OnPropertyChanged("CrateViewModel");
            } 
        
        }
        public BaseViewModel SelectedViewModel
        {
            get { return _selectedViewModel; }
            set 
            { 
                _selectedViewModel = value;
                OnPropertyChanged("SelectedViewModel");
            }
        }

        [JsonIgnore]
        public ICommand UpdateViewCommand { get; set; }
        [JsonIgnore]
        public ICommand OpenCrateCommand { get; set; }
        [JsonIgnore]
        public ICommand SearchCommand { get; set; }


        public MainViewModel()
        {
            UpdateViewCommand = new UpdateViewCommand(this);
            OpenCrateCommand = new OpenCrateCommand(this);
            SearchCommand = new SearchCommand(this);
            CratesViewModel = new CratesViewModel();
            CrateViewModel = new CrateViewModel();
            _searchResults = new ObservableCollection<string>();
            SearchResults = new ObservableCollection<string>();
            SelectedViewModel = CratesViewModel;

            //RegistryEdit.CreateSubkey();
        }

        public void ExecuteViewChange(object parameter)
        {

            if (parameter.ToString() == "CratesView")
            {
                this.SelectedViewModel = CratesViewModel;
            }
            else if (parameter.ToString() == "EditView")
            {
                this.SelectedViewModel = new EditViewModel(this);
            }
            else if (parameter.ToString() == "CrateView")
            {
               this.SelectedViewModel = CratesViewModel.SelectedCrateViewModel;
            }
        }

        public void ExecuteOpenCrateCommand(object parameter)
        {
            CratesViewModel.UpdateSelectedCrateViewModel(Convert.ToInt32(parameter));

            this.SelectedViewModel = CratesViewModel.SelectedCrateViewModel;
        }
        public void ExecuteSearchCommand(string s)
        {
            IEnumerable<CrateItem> results;

            if (s != null)
            {
                SearchResults.Clear();
            }


            if (!string.IsNullOrWhiteSpace(s))
            {
                foreach (Crate crate in CratesViewModel.Crates)
                {
                    results = crate.Items.Where(x => x.Name.Contains(s));

                    if (results.Any())
                    {
                        SearchResults.Add(crate.Name);
                    }

                }
            }
        }


    }
}
