using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Session9Assignment;

namespace Session9Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            propertiesClass obj = new propertiesClass();
            obj.rates = 2.3;
            System.Console.Write(obj.rates);
            System.Console.Read();

        }
    }
}
