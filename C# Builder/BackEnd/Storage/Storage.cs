using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Shelly
{
    public class Storage
    {
        #region Pages
        public PageRegistry Pages { get; private set; }
        #endregion

        #region Windows
        public Window CurWindow { get; set; }
        public Overview MainWindow { get; private set; }
        public Create CreateWindow { get; private set; }
        #endregion


        #region Database

        #endregion


        #region DataContext
        public SectionData DataBinding { get; set; }
        #endregion

        public Storage(Overview MainWindow)
        {
            DataBinding = new SectionData(this);
            Pages = new PageRegistry(this);   


            this.MainWindow = MainWindow;
            this.CurWindow = MainWindow;

            this.CreateWindow = new Create(this);
        }
    }
}
