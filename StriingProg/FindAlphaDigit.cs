using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.Sept_01
{
    public class FindAlphaDigit
    {
        //Write a C# program to find total number of alphabets, digits or special character in a string.
        static void Main(string[] args)
        {
            String str = "Rohit985046@#$Survase";
            char[] arr = str.ToCharArray();

            int aplhabet = 0;
            int digit = 0;
            int specialChar = 0;

            for(int i=0;i<arr.Length; i++)
            {
                if (char.IsLetter(str[i]))
                {
                    aplhabet++;
                }
                else if (char.IsDigit(str[i]))
                {
                    digit++;
                }
                else
                {
                    specialChar++;
                }
            }
            Console.WriteLine("Alphabet Count="+aplhabet);
            Console.WriteLine("Digit Count is="+digit);
            Console.WriteLine("SpecialCharcter is="+specialChar);
        }
    }
}
