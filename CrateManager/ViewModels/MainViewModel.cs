using System;
using System.Text.Json.Serialization;
using System.Windows;
using System.Windows.Input;

namespace CrateManager.ViewModels
{ 
    public class MainViewModel : BaseViewModel
    {
        private BaseViewModel _selectedViewModel;
        private CratesViewModel _cratesViewModel;
        private CrateViewModel _crateViewModel;
        private EditViewModel _editViewModel;

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
        public EditViewModel EditViewModel 
        {
            get
            {
                return _editViewModel;
            }
            set
            {
                _editViewModel = value;
                OnPropertyChanged("EditViewModel");
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


        public MainViewModel()
        {
            UpdateViewCommand = new UpdateViewCommand(this);
            OpenCrateCommand = new OpenCrateCommand(this);


            CratesViewModel = new CratesViewModel();
            CrateViewModel = new CrateViewModel();
            EditViewModel = new EditViewModel(this);

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
                this.SelectedViewModel = EditViewModel;
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
        
       
    }
}
