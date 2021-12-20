using CrateManager.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CrateManager
{
    public class UpdateViewCommand : ICommand
    {
        private MainViewModel _mainViewModel;

        public UpdateViewCommand(MainViewModel viewModel)
        {
            this._mainViewModel = viewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _mainViewModel.ExecuteViewChange(parameter);
        }
    }
}
