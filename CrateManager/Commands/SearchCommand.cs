using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using CrateManager.ViewModels;

namespace CrateManager
{
    public class SearchCommand : ICommand
    {
        private MainViewModel _mainVM;

        public event EventHandler CanExecuteChanged;

        public SearchCommand(MainViewModel mainViewModel)
        {
            _mainVM = mainViewModel;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _mainVM.ExecuteSearchCommand((string)parameter);
        }
    }
}
