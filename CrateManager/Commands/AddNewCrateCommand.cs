using CrateManager.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CrateManager
{
    public class AddNewCrateCommand : ICommand
    {
        private EditViewModel _createCrateVM;

        public event EventHandler CanExecuteChanged;

        public AddNewCrateCommand(EditViewModel createCrateViewModel)
        {
            _createCrateVM = createCrateViewModel;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _createCrateVM.ExecuteAddNewCrate();
        }
    }
}
