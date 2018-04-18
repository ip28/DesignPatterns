using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoR
{
    public abstract class BaseHandler
    {
       protected BaseHandler successor;

       public void SetSuccessor(BaseHandler nextHandler)
       {
           this.successor = nextHandler;
       }

       public abstract void HandleRequest(string request);
    }
}
