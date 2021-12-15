using CrateManager.Models;
using CrateManager.ViewModels;
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
            
        }

        private void ButtonNewItemEntry_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
