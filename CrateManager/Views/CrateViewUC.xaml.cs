using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CrateManager.Views
{
    /// <summary>
    /// Interaction logic for CrateViewUC.xaml
    /// </summary>
    public partial class CrateViewUC : UserControl
    {
        public CrateViewUC()
        {
            InitializeComponent();
            
        }

        private void MyDataGrid_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {

        //    DataGridLength dl = new DataGridLength(1.0, DataGridLengthUnitType.SizeToCells);

        //    MyDataGrid.CurrentColumn.Width = dl.Value;
        }
    }


}
