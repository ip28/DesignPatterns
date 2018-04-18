using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoR
{
    class DefaultHandler:BaseHandler
    {
        public override void HandleRequest(string request)
        {
            Console.WriteLine("This Request is Handled by DefaultHandler");
        }
    }
}
