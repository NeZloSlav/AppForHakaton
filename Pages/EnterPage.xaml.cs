using System.Windows.Controls;
using Hakaton.ClassHelper;

namespace Hakaton.Pages
{
    /// <summary>
    /// Логика взаимодействия для EnterPage.xaml
    /// </summary>
    public partial class EnterPage : Page
    {
        public EnterPage()
        {
            InitializeComponent();

            ClassHelper.NavigateClass.formsFrame = frmForms;

            NavigateClass.formsFrame.Navigate(new RegEnterPage());
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            NavigateClass.navigFrame.Navigate(new MainPage());
        }
    }
}
