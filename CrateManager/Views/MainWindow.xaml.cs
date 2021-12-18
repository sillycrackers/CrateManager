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

        public MainWindow()
        {

            InitializeComponent();

            DataContext = new MainViewModel();
        }

        private void ShowCrateView(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
