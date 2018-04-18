using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command
{
   public class MultiInvoker
    {
       private List<ICommand> commands = new List<ICommand>();
       public void QueueCommand(ICommand cmd)
       {
           this.commands.Add(cmd);
       }

       public void ExecuteAllCommands()
       {
           foreach (ICommand cmd in this.commands)
           {
               try
               {
                   cmd.Execute();
               }
               catch (Exception)
               {

                   cmd.Undo();
               }
           }
       }
    }
}
