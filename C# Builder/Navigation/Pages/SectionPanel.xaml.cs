using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Shelly
{
    /// <summary>
    /// Interaktionslogik für FirstSectionSide.xaml
    /// </summary>
    public partial class SectionPanel : Page
    {
        Storage Store;

        public SectionPanel(Storage Store)
        {
            InitializeComponent();
            this.Store = Store;
        }

        private void Windows_Click(object sender, RoutedEventArgs e)
        {
            Store.Pages.GoToPage(Store.Pages.WindowsPage);
        }

        private void Programs_Click(object sender, RoutedEventArgs e)
        {
            Store.Pages.GoToPage(Store.Pages.ProgramsPage);
        }

        private void Password_Manager_Click(object sender, RoutedEventArgs e)
        {
            Store.Pages.GoToPage(Store.Pages.PasswordManagerPage);
        }

        private void Layout_Click(object sender, RoutedEventArgs e)
        {
            Store.Pages.GoToPage(Store.Pages.LayoutPage);
        }

        private void Web_Click(object sender, RoutedEventArgs e)
        {
            Store.Pages.GoToPage(Store.Pages.WebPage);
        }

        private void Input_Click(object sender, RoutedEventArgs e)
        {
            Store.Pages.GoToPage(Store.Pages.InputPage);
        }
    }
}
