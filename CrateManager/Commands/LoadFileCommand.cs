using CrateManager.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CrateManager
{
    public class LoadFileCommand : ICommand
    {
        private MainMenuViewModel _mainMenuVM;

        public event EventHandler CanExecuteChanged;

        public LoadFileCommand(MainMenuViewModel mainMenuViewModel)
        {
            _mainMenuVM = mainMenuViewModel;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _mainMenuVM.ExecuteLoadFile();
        }
    }
}
