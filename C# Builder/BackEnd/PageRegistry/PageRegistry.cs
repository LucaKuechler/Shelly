using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Shelly
{
    public class PageRegistry
    {
        public Page CurPage { get; set; }

        public SectionPanel SectionPage { get; private set; }
        public Workspace WorkspacePage { get; private set; }

        public ProgramsPanel ProgramsPage { get; private set; }

        public InputsPanel InputPage { get; private set; }
        public LayoutPanel LayoutPage { get; private set; }
        public PasswordManagerPanel PasswordManagerPage { get; private set; }
        public WebPanel WebPage { get; private set; }
        public WindowsPanel WindowsPage { get; private set; }


        public PageRegistry(Storage Store)
        {
            // all pages are created here
            WorkspacePage = new Workspace(Store);
            SectionPage = new SectionPanel(Store);
            CurPage = SectionPage;

            ProgramsPage = new ProgramsPanel(Store);

            InputPage = new InputsPanel(Store);
            LayoutPage = new LayoutPanel(Store);
            PasswordManagerPage = new PasswordManagerPanel(Store);    
            WebPage = new WebPanel(Store);
            WindowsPage = new WindowsPanel(Store);

        }

        public void GoToPage(Page Object)
        {
            CurPage.NavigationService.Navigate(Object);
            CurPage = Object;
        }

    }
}
