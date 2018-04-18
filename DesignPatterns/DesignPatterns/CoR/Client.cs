using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoR
{
    class Client
    {
        static void Main(string[] args)
        {
            ConcreteHandler1 h1 = new ConcreteHandler1();
            ConcreteHandler2 h2 = new ConcreteHandler2();
            DefaultHandler dh = new DefaultHandler();
            h1.SetSuccessor(h2);
            h2.SetSuccessor(dh);
            h1.HandleRequest("One");
            h1.HandleRequest("Two");
            h1.HandleRequest("three");
            Console.ReadLine();
        }
    }
}
