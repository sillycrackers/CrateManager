using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using CrateManager.ViewModels;

namespace CrateManager
{
    class GenerateCrateCommand : ICommand
    {
        private CratesViewModel _crateVM;

        public event EventHandler CanExecuteChanged;

        public GenerateCrateCommand(CratesViewModel viewModel)
        {
            _crateVM = viewModel;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _crateVM.ExecuteGenerateCrate();
        }
    }
}
