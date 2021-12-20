using CrateManager.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CrateManager
{
    class AddCategoryCommand : ICommand
    {
        private CreateCrateViewModel _viewModel;

        public event EventHandler CanExecuteChanged;


        public AddCategoryCommand(CreateCrateViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _viewModel.ExecuteAddCategoryCommand(parameter);
        }
    }
}
