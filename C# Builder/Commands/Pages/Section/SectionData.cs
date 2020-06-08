using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Diagnostics.Tracing;
using System.Diagnostics;

namespace Shelly
{
    public class SectionData
    {
        Storage Store;

        #region Functions
        /// <summary>
        /// All Functions will be defined here
        /// </summary>

        #region 
        ICommand BackToSection;

        public ICommand BackToSectionFunction
        {
            get { return BackToSection; }
        }
        #endregion

        #endregion


        public SectionData(Storage Store)
        {
            this.Store = Store;
            Trace.WriteLine("asd");
            BackToSection = new BackToSection(Store);
        }
    }
}
