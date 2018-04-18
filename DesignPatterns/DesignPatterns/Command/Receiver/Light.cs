using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command
{
   public class Light:IReceiver
    {
       //Action
       public void TurnOn()
       {
           Console.WriteLine("Lights are turned on");
       }
       public void TurnOff()
       {
           Console.WriteLine("Lights are turned off");
       }
    }
}
