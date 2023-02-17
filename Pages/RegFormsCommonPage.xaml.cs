using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using Hakaton.ClassHelper;

namespace Hakaton.Pages
{
    /// <summary>
    /// Логика взаимодействия для RegFormsCommonPage.xaml
    /// </summary>
    public partial class RegFormsCommonPage : Page
    {
        public RegFormsCommonPage()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            NavigateClass.rightPartFrame.Navigate(new RegFormsAdditionalPage());
        }

        private void hlinkLogPage_Click(object sender, RoutedEventArgs e)
        {
            NavigateClass.leftPartFrame.Navigate(new LogPage());
            NavigateClass.rightPartFrame.Navigate(new LogFormsPage());
        }

        private void tbxSurname_LostFocus(object sender, RoutedEventArgs e)
        {
            if (tbxSurname.Text.ValidateTextField(false))
            {
                tbxSurname.BorderBrush = Brushes.DimGray;
            }
            else
            {
                tbxSurname.BorderBrush = Brushes.Red;
            }
        }

        private void tbxName_LostFocus(object sender, RoutedEventArgs e)
        {
            if (tbxName.Text.ValidateTextField(false))
            {
                tbxName.BorderBrush = Brushes.DimGray;
            }
            else
            {
                tbxName.BorderBrush = Brushes.Red;

            }
        }

        private void tbxPatronymic_LostFocus(object sender, RoutedEventArgs e)
        {
            if (tbxSurname.Text.ValidateTextField(false))
            {
                tbxPatronymic.BorderBrush = Brushes.DimGray;
            }
            else
            {
                tbxPatronymic.BorderBrush = Brushes.Red;
            }
        }

        private void tbxStudentBilet_LostFocus(object sender, RoutedEventArgs e)
        {

        }

        private void tbxPhone_LostFocus(object sender, RoutedEventArgs e)
        {
            if (tbxPhone.Text.ValidatePhoneNumber(false))
            {

                tbxPhone.BorderBrush = Brushes.DimGray;
            }
            else
            {
                tbxPhone.BorderBrush = Brushes.Red;
            }
        }

        private void tbxEmail_LostFocus(object sender, RoutedEventArgs e)
        {
            if (tbxEmail.Text.ValidateEmailAddress(false))
            {
                tbxEmail.BorderBrush = Brushes.DimGray;
            }
            else
            {
                tbxEmail.BorderBrush = Brushes.Red;
            }
        }

        private void pswPassword_LostFocus(object sender, RoutedEventArgs e)
        {

        }
    }
}
