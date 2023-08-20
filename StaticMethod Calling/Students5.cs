using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.StaticMethod
{
    public class Students5
    {
        int x;
        static int j;
        static Students5()
        {
            Console.WriteLine("Hi");
            j = 100;
        }
        public Students5()
        {
            Console.WriteLine("Hello");
            x = 233;
 
        }
        public string show()
        {
            return $"{x}{j}";
        }
    }
}
