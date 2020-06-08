using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Shelly
{
    class Cancel : ICommand
    {
        Storage Store;
        public event EventHandler CanExecuteChanged;


        public Cancel(Storage Store)
        {
            this.Store = Store;
        }


        public bool CanExecute(object parameter)
        {
            return true;
        }


        public void Execute(object parameter)
        {
            Overview MainWindow = new Overview();
            MainWindow.Show();
            Store.CreateWindow.Close();
        }
    }
}
