using CrateManager.Models;
using System.Windows;


namespace CrateManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Crate CurrentCrate { get; set; }
        public MainWindow()
        {
            CurrentCrate = new Crate();
            InitializeComponent();

            this.listView_Items.DataContext = CurrentCrate;
        }

        private void ButtonNewItemEntry_Click(object sender, RoutedEventArgs e)
        {
            CurrentCrate.Items.Add(new CrateItem(this.TextBoxNewItem.Text));
        }
    }
}
