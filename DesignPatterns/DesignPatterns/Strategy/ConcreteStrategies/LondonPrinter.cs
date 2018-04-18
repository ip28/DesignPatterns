using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy.ConcreteStrategies
{
   public class LondonPrinter :IPrinter
    {
        #region IPrinter Members

        public void Print(string input)
        {
            Console.WriteLine(input + "(This text is printed in London)");
        }

        #endregion
    }
}
