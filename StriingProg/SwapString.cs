using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.StriingProg
{
    public class SwapString
    {
        	//How do you swap two string variables without using third or temp variable in C#
        static void Main(string[] args)
        {
            string str = "Rohit";
            String str2 = "Survase";

            Console.WriteLine($"Before Swaping {str} and {str2}");

            str = str + str2;
            str2 = str.Substring(str.Length - str2.Length);
            str = str.Substring(str2.Length);

            Console.WriteLine($"After Swaping String {str} and {str2}");

        }
    }
}
