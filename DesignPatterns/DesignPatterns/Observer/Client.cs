using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Observer.Subject;
using Observer.Observers;

namespace Observer
{
    class Client
    {
        static void Main(string[] args)
        {
            ConcreteSubject subject = new ConcreteSubject();
            subject.Val = "Test";
            subject.Attach(new Observer1(subject));
            subject.Val = "Changed";
            subject.Val = "AgainChanged";          
            Console.ReadLine();           
        }
    }
}
