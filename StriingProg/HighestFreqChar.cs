using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.Sept_01
{
    public class HighestFreqChar
    {
        //Write a C# program to find highest frequency character in a string.
        static void Main(string[] args)
        {
            string str = "India is My Cooountry";
            int count = 0;

            char[]ch= str.ToCharArray();
            for(int i = 0; i < str.Length; i++)
            {
                if (ch[i] == 'i')
                {
                    count++; 
                }
            }
            Console.WriteLine("Highest Freq No="+count);
        }
    }
}
