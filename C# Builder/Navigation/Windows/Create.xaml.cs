using SourceWeave.Controls;
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
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class Create : SWWindow
    {

        public Create(Storage Store)
        {
            InitializeComponent();

            LeftSideFrame.Navigate(Store.Pages.SectionPage);
            RightSideFrame.Navigate(Store.Pages.WorkspacePage);
        }

        private void Frame_Navigating(object sender, NavigatingCancelEventArgs e)
        {
            if (e.NavigationMode == NavigationMode.Forward)
            {
                e.Cancel = true;
            }
            if (e.NavigationMode == NavigationMode.Back)
            {
                e.Cancel = true;
            }
            else { }
        }
    }
}
