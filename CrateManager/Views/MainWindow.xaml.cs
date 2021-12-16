using CrateManager.Models;
using CrateManager.ViewModels;
using CrateManager.Views;
using System.Windows;


namespace CrateManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public CrateViewModel SelectedCrate { get; set; }
        public MainWindow()
        {
            SelectedCrate = new CrateViewModel();

            InitializeComponent();

            listView_Items.DataContext = SelectedCrate;

        }

        private void ButtonNewItemEntry_Click(object sender, RoutedEventArgs e)
        {
            SelectedCrate.Items.Add(new CrateItem(TextBoxNewItem.Text));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CrateWindow crateWindow = new CrateWindow();

            crateWindow.Show();
        }
    }
}
