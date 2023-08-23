using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.ToString
{
    public class StringBuilder1
    {
        static void Main(string[] args)
        {
            string str1 = "Hello to all";
            Console.WriteLine(str1);
            Console.WriteLine(str1.GetHashCode());

            Console.WriteLine("----String Builder Class_____");
            StringBuilder sb= new StringBuilder("Hello to all");
            Console.WriteLine(sb.GetHashCode());//Address

            sb.Append("Good Morning");
            Console.WriteLine(sb);
            Console.WriteLine(sb.GetHashCode());
        }
    }
}
