using System;
using System.Windows;
using System.Windows.Input;

namespace CrateManager.ViewModels
{ 
    public class MainViewModel : BaseViewModel
    {
        private BaseViewModel _selectedViewModel;

        public CratesViewModel CratesViewModel { get; set; }
        public CrateViewModel CrateViewModel { get; set; }
        public CreateCrateViewModel CreateCrateViewModel { get; set; }
        public BaseViewModel SelectedViewModel
        {
            get { return _selectedViewModel; }
            set 
            { 
                _selectedViewModel = value;
                OnPropertyChanged("SelectedViewModel");
            }
        }

        public ICommand UpdateViewCommand { get; set; }
        public ICommand OpenCrateCommand { get; set; }

        public MainViewModel()
        {
            UpdateViewCommand = new UpdateViewCommand(this);
            OpenCrateCommand = new OpenCrateCommand(this);
            CratesViewModel = new CratesViewModel();
            CrateViewModel = new CrateViewModel();
            CreateCrateViewModel = new CreateCrateViewModel(CratesViewModel);
        }

        public void ExecuteViewChange(object parameter)
        {

            if (parameter.ToString() == "CratesView")
            {
                this.SelectedViewModel = CratesViewModel;
            }
            else if (parameter.ToString() == "CreateCrateView")
            {
                this.SelectedViewModel = CreateCrateViewModel;
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
