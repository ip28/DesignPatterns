using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command.ConcreteCommand
{
   public class SwitchOffCommand:ICommand
    {
       private IReceiver receiver;
       public SwitchOffCommand(IReceiver light)
       {
           this.receiver = light;
       }
        #region ICommand Members

        public void Execute()
        {
            this.receiver.TurnOff();
        }

        public void Undo()
        {
            this.receiver.TurnOn();
        }

        #endregion
    }
}
