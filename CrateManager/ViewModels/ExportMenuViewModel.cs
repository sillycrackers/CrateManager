using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using CrateManager.Models;

namespace CrateManager.ViewModels
{
    public class ExportMenuViewModel
    {
        private MainViewModel _mainVM;

        public ICommand ExportCsvCommand { get; set; }

        public ExportMenuViewModel(Window window)
        {
            _mainVM = (MainViewModel)window.DataContext;

            ExportCsvCommand = new ExportCsvCommand(this);
        }

        public void ExecuteExportCsv()
        {
            FileManagement.ExportCSV(GenerateCsvOutput());
        }

        private string GenerateCsvOutput()
        {
            StringBuilder output = new StringBuilder();

            foreach(Crate c in _mainVM.CratesViewModel.Crates)
            {
                output.AppendLine(c.Name);
                output.AppendLine();

                //Print header for items 
                output.AppendLine("Name,PartNumber,Quantity,Description");

                //Print item information
                foreach(CrateItem i in c.Items)
                {
                    output.Append(i.Name);
                    output.Append(',');
                    output.Append(i.PartNumber);
                    output.Append(',');
                    output.Append(i.Quantity);
                    output.Append(',');
                    output.Append(i.Description);
                    output.AppendLine();
                }

                output.AppendLine();
                output.AppendLine();
            }


            return output.ToString();
            
        }
    }
}
