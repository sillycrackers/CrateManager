using CrateManager.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CrateManager
{
    public class SaveFileCommand : ICommand
    {
        private MainViewModel _mainVM;

        public event EventHandler CanExecuteChanged;

        public SaveFileCommand(MainViewModel mainViewModel)
        {
            _mainVM = mainViewModel;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _mainVM.ExecuteSaveFile();
        }
    }
}
