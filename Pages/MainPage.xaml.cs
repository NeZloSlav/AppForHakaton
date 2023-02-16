using System.Windows;
using System.Windows.Controls;
using Hakaton.ClassHelper;

namespace Hakaton.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }


        private void btnIStudent_Click(object sender, RoutedEventArgs e)
        {
            ClassHelper.NavigateClass.navigFrame.Navigate(new EnterPage());
            
        }

        private void btnIApplicant_Click(object sender, RoutedEventArgs e)
        {
            ClassHelper.NavigateClass.navigFrame.Navigate(new StudentsCatalog());
        }
    }
}
