using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.Sept_01
{
    public class PrintString
    {   //Wc to accept two string and calculate length of string
        static void Main(string[] args)
        {
            string str = "Hello World";
            string str2 = "My Praticeof";
            Console.WriteLine("String One="+str);
            Console.WriteLine("String Sec is="+str2);

            int count=str.Length;
            int length2=str2.Length;

            Console.WriteLine("First String Count is="+count);
            Console.WriteLine("Second String Length is="+length2);
        }
    }
}
