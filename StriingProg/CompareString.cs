using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.Sept_01
{
    public class CompareString
    {
        //C# program to compare two strings using string.CompareTo() method
        static void Main(string[] args)
        {
            string str = "Hello";
            String str2 = "Hello2";

            /*if (str.CompareTo(str2) == 0)
            {
                Console.WriteLine("String Matched");
            }
            else
            {
                Console.WriteLine("String Not Matched");
            }
            if (str2.CompareTo("Hello2") == 0)
            {
                Console.WriteLine("String is matched");
            }
            else
            {
                Console.WriteLine("String is not matched");
            }*/

           // if (str == str2)
            if (str == "Hello")
            {
                Console.WriteLine("String is matched");
            }
            else
            {
                Console.WriteLine("String is not Matched");
            }
        }
    }
}
