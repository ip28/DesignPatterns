using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoR
{
    class ConcreteHandler2:BaseHandler
    {
        public override void HandleRequest(string request)
        {
            if (request.Equals("Two", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("This Request is Handled by ConcreteHandler2");
            }
            else
            {
                base.successor.HandleRequest(request);
            }
        }
    }
}
