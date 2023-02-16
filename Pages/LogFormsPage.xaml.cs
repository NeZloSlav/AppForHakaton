using System.Windows;
using System.Windows.Controls;
using Hakaton.ClassHelper;

namespace Hakaton.Pages
{
    /// <summary>
    /// Логика взаимодействия для LogFormsPage.xaml
    /// </summary>
    public partial class LogFormsPage : Page
    {
        public LogFormsPage()
        {
            InitializeComponent();
        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            NavigateClass.rightPartFrame.Navigate(new RegFormsCommonPage());
            NavigateClass.leftPartFrame.Navigate(new RegistrationPage());
        }
    }
}
