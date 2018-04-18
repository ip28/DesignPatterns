using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command
{
   public class Invoker
    {
       public void ExecuteCommand(ICommand cmd)
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
