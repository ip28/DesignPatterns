using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command
{
   public class SwitchOnCommand:ICommand
    {
       private IReceiver receiver;
       public SwitchOnCommand(IReceiver light)
       {
           this.receiver = light;
       }
        #region ICommand Members

        public void Execute()
        {
            this.receiver.TurnOn();
        }

        public void Undo()
        {
            this.receiver.TurnOff();
        }

        #endregion
    }
}
