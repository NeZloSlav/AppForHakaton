using System.Windows;
using System.Windows.Controls;
using Hakaton.ClassHelper;

namespace Hakaton.Pages
{
    /// <summary>
    /// Логика взаимодействия для RegFormsAdditionalPage.xaml
    /// </summary>
    public partial class RegFormsAdditionalPage : Page
    {
        public RegFormsAdditionalPage()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigateClass.rightPartFrame.GoBack();
        }
    }
}
