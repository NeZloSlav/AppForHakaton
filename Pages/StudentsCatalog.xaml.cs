using Hakaton.ClassHelper;
using System.Windows;
using System.Windows.Controls;

namespace Hakaton.Pages
{
    /// <summary>
    /// Логика взаимодействия для StudentsCatalog.xaml
    /// </summary>
    public partial class StudentsCatalog : Page
    {
        public StudentsCatalog()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigateClass.navigFrame.Navigate(new MainPage());
        }
    }
}
