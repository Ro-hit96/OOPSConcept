using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.Sept_01
{
    	//Write a C# program to find reverse of a string.
    public class ReverseStrigs
    {
        static void Main(string[] args)
        {
            string str = "ABCD";
            string str2 = "";

            // Get the length of the string
            int length = str.Length;

            for(int i=length-1; i>=0; i--)
            {
                str2=  str2+ str[i] ;
            }

            Console.WriteLine("Reverse String is="+str2);

        }
    }
}
