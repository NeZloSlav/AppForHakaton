using System.Windows;
using System.Windows.Controls;
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
    }
}
