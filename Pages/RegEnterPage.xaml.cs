using System.Windows.Controls;
using Hakaton.ClassHelper;

namespace Hakaton.Pages
{
    /// <summary>
    /// Логика взаимодействия для RegEnterPage.xaml
    /// </summary>
    public partial class RegEnterPage : Page
    {
        public RegEnterPage()
        {
            InitializeComponent();

            NavigateClass.leftPartFrame = frmLeftPart;
            NavigateClass.rightPartFrame = frmRightPart;

            NavigateClass.leftPartFrame.Navigate(new RegistrationPage());
            NavigateClass.rightPartFrame.Navigate(new RegFormsCommonPage());
        }
    }
}
