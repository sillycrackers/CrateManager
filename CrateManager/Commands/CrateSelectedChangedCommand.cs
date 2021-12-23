using CrateManager.ViewModels;
using System;
using System.Windows.Input;

namespace CrateManager
{
    public class CrateSelectedChangedCommand : ICommand
    {
        private EditViewModel _editVM;

        public event EventHandler CanExecuteChanged;

        public CrateSelectedChangedCommand(EditViewModel editViewModel)
        {
            _editVM = editViewModel;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _editVM.ExecuteCrateSelectedChanged();
        }
    }
}
