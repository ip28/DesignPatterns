using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy.Context
{
   public class PrintContext
    {
       private IPrinter printer;
       private string inputString;
       public PrintContext(IPrinter inputPrinter,string textToPrint)
       {
           this.printer = inputPrinter;
           this.inputString = textToPrint;
       }

       public void PrintText()
       {
           this.printer.Print(this.inputString);
       }
    }
}
