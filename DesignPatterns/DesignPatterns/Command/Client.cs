using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command
{
    class Client
    {
        static void Main(string[] args)
        {
            //Init Receivers
            IReceiver lightReceiver = new Light();
            IReceiver projectorReceiver = new Projector();

            //Init Commands
            ICommand lightCommand = new SwitchOnCommand(lightReceiver);
            ICommand projectorCommand = new SwitchOnCommand(projectorReceiver);

            Invoker invoker = new Invoker();
            invoker.ExecuteCommand(lightCommand);
            invoker.ExecuteCommand(projectorCommand);
            Console.ReadLine();
        }
    }
}
