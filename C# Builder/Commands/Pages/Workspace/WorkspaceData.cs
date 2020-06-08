using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Shelly
{
    class WorkspaceData
    {
        Storage Store;

        #region Functions
        /// <summary>
        /// All Functions will be defined here
        /// </summary>

        #region 
        ICommand Cancel;

        public ICommand CancelFunction
        {
            get { return Cancel; }
        }
        #endregion

        #endregion


        public WorkspaceData(Storage Store)
        {
            this.Store = Store;

            Cancel = new Cancel(Store);
        }
    }
}
