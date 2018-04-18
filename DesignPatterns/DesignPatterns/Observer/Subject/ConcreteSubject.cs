using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer.Subject
{
 public class ConcreteSubject:BaseSubject
    {
     private string _val;
     public string Val
     {
         get
         {
             return this._val;
         }
         set
         {
             string oldVal = this._val;
             this._val = value;
             if (oldVal != value)
             {
                 base.Notify();
             }
         }
     }
     }
}
