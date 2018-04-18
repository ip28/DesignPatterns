using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Strategy.Context;
using Strategy.ConcreteStrategies;
namespace Strategy
{
    class Client
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your location");
            string office = Console.ReadLine();
            Console.WriteLine("Enter the text to print");
            string textToPrint = Console.ReadLine();
            
            PrintContext context;
            switch (office.ToUpper())
            {
                case "MUMBAI":
                    context = new PrintContext(new MumbaiPrinter(), textToPrint);
                    context.PrintText();
                    break;
                case "PARIS":
                    context = new PrintContext(new ParisPrinter(), textToPrint);
                    context.PrintText();
                    break;
                case "LONDON":
                    context = new PrintContext(new LondonPrinter(), textToPrint);
                    context.PrintText();
                    break;
                default:
                    throw new Exception("Location Not Found");
            }

            Console.ReadLine();
        }
    }
  
}
