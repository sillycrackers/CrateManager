using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;


namespace CrateManager.Views
{

    /// <summary>
    /// Interaction logic for CreateCrateUC.xaml
    /// </summary>
    public partial class EditViewUC : UserControl
    {

        public EditViewUC()
        {
            
            InitializeComponent();
        }

        /// <summary>
        /// Button Click create new crate
        /// </summary>
        private void ClickCreate(object sender, System.Windows.RoutedEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(TextBoxName.Text) || string.IsNullOrWhiteSpace(TextBoxKeyItems.Text) || string.IsNullOrWhiteSpace(ComboBoxCategory.Text))
            {
                TextBlockWarning.Visibility = Visibility.Visible;
            }
        }

        private void ButtonCreateLostFocus(object sender, System.Windows.RoutedEventArgs e)
        {
            TextBlockWarning.Visibility = Visibility.Hidden;
        }

        /// <summary>
        /// Button Click update existing crate
        /// </summary>
        private void ClickUpdateEdit(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxNameEdit.Text) || string.IsNullOrWhiteSpace(TextBoxKeyItemsEdit.Text) || string.IsNullOrWhiteSpace(ComboBoxCategoryEdit.Text))
            {
                TextBlockWarningEdit.Visibility = Visibility.Visible;
            }
        }

        private void ButtonEditLostFocus(object sender, RoutedEventArgs e)
        {
            TextBlockWarningEdit.Visibility = Visibility.Hidden;
        }


    }
}
