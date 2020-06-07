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
        public SectionPanel()
        {
            InitializeComponent();
        }

        private void Windows_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new WindowsPanel());
        }

        private void Programs_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new ProgramsPanel());
        }

        private void Password_Manager_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new PasswordManagerPanel());
        }

        private void Layout_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new LayoutPanel());
        }

        private void Web_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new WebPanel());
        }

        private void Input_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new InputsPanel());
        }
    }
}
