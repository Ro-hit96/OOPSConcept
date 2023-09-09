using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.Sept_01
{
    	//Write a C# program to reverse order of words in a given string.
    public class ReverseOrderofWord
    {
        static void Main(string[] args)
        {
            string str = "INDIA is My Conuntry";
            string[] strArr = str.Split();

            string str3 = " ";
            

            char[] ch = str.ToCharArray();
            for(int i = str.Length - 1; i >= 0; i--)
            {
                str3 = str3 + str[i];
                
            }
            Console.WriteLine(str3);

        }
    }
}
