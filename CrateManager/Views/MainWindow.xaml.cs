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

            //Blank view
            DataContext = new MainViewModel();

            //Create new Menu object passing in this window. When loading file it will assign it to the window's Datacontext
            MainMenu.DataContext = new MainMenuViewModel(this);
        }
    }
}
