using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Observer.Subject;

namespace Observer.Observers
{
   public class Observer1:IObserver
    {
       private ConcreteSubject subject;
       public Observer1(ConcreteSubject sub)
       {
           this.subject = sub;
       }
        #region IObserver Members

        public void Update()
        {
            Console.WriteLine("Observer1: New State of Object is:" + this.subject.Val);
        }

        #endregion
    }
}
