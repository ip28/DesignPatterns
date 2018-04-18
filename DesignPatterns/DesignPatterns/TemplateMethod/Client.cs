using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TemplateMethod.DBProviders;

namespace TemplateMethod
{
    class Client
    {
        static void Main(string[] args)
        {
            BaseDAL sqldao = new SqlDbProvider();
            sqldao.Run();
            BaseDAL oledbdao = new OLEDbProvider();
            oledbdao.Run();
            Console.ReadLine();
        }
    }
}
