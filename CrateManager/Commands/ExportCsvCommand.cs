using CrateManager.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CrateManager
{
    public class ExportCsvCommand : ICommand
    {
        private ExportMenuViewModel _exportMenuVM;

        public event EventHandler CanExecuteChanged;

        public ExportCsvCommand(ExportMenuViewModel mainViewModel)
        {
            _exportMenuVM = mainViewModel;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _exportMenuVM.ExecuteExportCsv();
        }
    }
}
