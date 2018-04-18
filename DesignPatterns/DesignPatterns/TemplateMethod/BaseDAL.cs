using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemplateMethod
{
   public abstract class BaseDAL
    {
       protected string connectionString;
       public virtual void Connect()
       {
           this.connectionString = "Test";
           Console.WriteLine("Connecting....");
       }
       public abstract void GetData();
       public virtual void Disconnect()
       {
           connectionString = string.Empty;
           Console.WriteLine("Disconnected");
       }

       public void Run()
       {
           this.Connect();
           this.GetData();
           this.Disconnect();
       }

    }
}
