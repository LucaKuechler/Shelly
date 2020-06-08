using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Shelly
{
    class CreateCommand : ICommand
    {
        Storage Store;
        public event EventHandler CanExecuteChanged;


        public CreateCommand(Storage Store)
        {
            this.Store = Store;
        }


        public bool CanExecute(object parameter)
        {
            return true;
        }


        public void Execute(object parameter)
        {
            Store.CreateWindow.Show();
            Store.MainWindow.Close();
            Store.CurWindow = Store.CreateWindow;
        }
    }
}
