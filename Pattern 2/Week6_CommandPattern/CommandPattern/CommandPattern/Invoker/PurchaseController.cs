using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class PurchaseController
    {
        private ICommand commands;

        public void InsertCommand(ICommand command)
        {
            this.commands = command;
        }
        
        public void ExecuteCommand()
        {
            commands.Execute();
        }
    }
}
