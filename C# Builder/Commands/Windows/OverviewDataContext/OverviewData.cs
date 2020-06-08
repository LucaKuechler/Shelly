using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Shelly
{
    class OverviewData
    {
        Storage Store;

        #region Functions
        /// <summary>
        /// All Functions will be defined here
        /// </summary>

        #region 
        ICommand CreateCommand;

        public ICommand CreateCommandFunction
        {
            get { return CreateCommand; }
        }
        #endregion


        #endregion


        public OverviewData(Storage Store)
        {
            this.Store = Store;

            CreateCommand = new CreateCommand(Store);
        }
    }
}
