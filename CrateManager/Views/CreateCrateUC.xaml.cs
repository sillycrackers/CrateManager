using System.Windows.Controls;


namespace CrateManager.Views
{

    /// <summary>
    /// Interaction logic for CreateCrateUC.xaml
    /// </summary>
    public partial class CreateCrateUC : UserControl
    {

        public CreateCrateUC()
        {
            InitializeComponent();
        }

        private void ClickCreate(object sender, System.Windows.RoutedEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(TextBoxName.Text) || string.IsNullOrWhiteSpace(TextBoxKeyItems.Text) || string.IsNullOrWhiteSpace(ComboBoxCategory.Text))
            {
                TextBlockWarning.Visibility = System.Windows.Visibility.Visible;
            }
        }

        private void ButtonCreateLostFocus(object sender, System.Windows.RoutedEventArgs e)
        {
            TextBlockWarning.Visibility = System.Windows.Visibility.Hidden;
        }
    }
}
