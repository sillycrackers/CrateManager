using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace CrateManager.ViewModels
{
    public class MainMenuViewModel
    {
        private string _currentFilePath { get; set; } = "";
        private MainViewModel _mainVM;
        private Window _window;

        public ICommand SaveFileCommand { get; set; }
        public ICommand SaveAsFileCommand { get; set; }
        public ICommand LoadFileCommand { get; set; }
 

        public MainMenuViewModel(Window window)
        {
            SaveFileCommand = new SaveFileCommand(this);
            SaveAsFileCommand = new SaveAsFileCommand(this);
            LoadFileCommand = new LoadFileCommand(this);

            _mainVM = (MainViewModel)window.DataContext;
            _window = window;
        }

        public void ExecuteSaveFile()
        {
            
            if (!string.IsNullOrWhiteSpace(_currentFilePath))
            {
                FileManagement.SaveFile(_mainVM, _currentFilePath);
            }
            else
            {
                ExecuteSaveAsFile();
            }
        }

        public void ExecuteSaveAsFile()
        {
            string path = FileManagement.SelectSaveFile(FileManagement.FileType.Crate);

            if (path != null)
            {
                _currentFilePath = path;
                FileManagement.SaveFile(_mainVM, path);
            }
        }

        public void ExecuteLoadFile()
        {
            string path = FileManagement.SelectLoadFile(FileManagement.FileType.Crate);

            if (path != null)
            {
                _mainVM = FileManagement.LoadFile<MainViewModel>(path);
                _mainVM.SelectedViewModel = _mainVM.CratesViewModel;
                _currentFilePath = path;
                _window.DataContext = _mainVM;
            }

        }

    }
}
