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
        public EditViewModel EditViewModel { get; set; }
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
        public ICommand SaveFileCommand { get; set; }
        public ICommand LoadFileCommand { get; set; }

        public MainViewModel()
        {
            UpdateViewCommand = new UpdateViewCommand(this);
            OpenCrateCommand = new OpenCrateCommand(this);
            SaveFileCommand = new SaveFileCommand(this);
            LoadFileCommand = new LoadFileCommand(this);

            CratesViewModel = new CratesViewModel();
            CrateViewModel = new CrateViewModel();
            EditViewModel = new EditViewModel(this);

            SelectedViewModel = CratesViewModel;

            RegistryEdit.CreateSubkey();
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
        
        public void ExecuteSaveFile()
        {
            string path = FileManagement.SelectSaveFile();

            if (path != null)
            {
                FileManagement.SaveFile(CratesViewModel, path);
            }
        }

        public void ExecuteLoadFile()
        {
            string path = FileManagement.SelectLoadFile();

            if(path != null)
            {
                CratesViewModel = FileManagement.LoadFile<CratesViewModel>(path);
            }
  
        }
    }
}
