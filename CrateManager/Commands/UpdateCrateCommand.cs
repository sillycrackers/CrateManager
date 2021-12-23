using CrateManager.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CrateManager
{
    public class UpdateCrateCommand : ICommand
    {
        private EditViewModel _editVM;

        public event EventHandler CanExecuteChanged;

        public UpdateCrateCommand(EditViewModel editViewModel)
        {
            _editVM = editViewModel;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _editVM.ExecuteUpdateCrate();
        }
    }
}
