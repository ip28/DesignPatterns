using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoR
{
    class ConcreteHandler1:BaseHandler
    {
        public override void HandleRequest(string request)
        {
            if (request.Equals("One", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("This Request is Handled by ConcreteHandler1");
            }
            else
            {
                base.successor.HandleRequest(request);
            }
        }
    }
}
