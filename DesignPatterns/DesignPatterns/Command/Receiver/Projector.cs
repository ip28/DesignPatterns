using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command
{
   public class Projector:IReceiver
    {
        #region IReceiver Members

        public void TurnOn()
        {
            throw new Exception();
            //Console.WriteLine("Projector is turned On");
        }

        public void TurnOff()
        {
            Console.WriteLine("Projector is turned Off");
        }

        #endregion
    }
}
