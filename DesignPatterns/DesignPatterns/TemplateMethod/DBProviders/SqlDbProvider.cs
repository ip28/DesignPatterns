using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemplateMethod.DBProviders
{
   public class SqlDbProvider:BaseDAL
    {
        public override void GetData()
        {
            Console.WriteLine("This data is from SqlDbProvider");
        }
    }
}
