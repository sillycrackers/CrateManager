using CrateManager.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CrateManager
{
    public class OpenCrateCommand : ICommand
    {

        private MainViewModel _viewModel;

        public event EventHandler CanExecuteChanged;

        public OpenCrateCommand(MainViewModel viewModel)
        {
            this._viewModel = viewModel;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _viewModel.ExecuteOpenCrateCommand(parameter);
        }
    }
}
