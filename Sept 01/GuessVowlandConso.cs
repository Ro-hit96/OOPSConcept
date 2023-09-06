using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.Sept_01
{
    public class GuessVowlandConso
    {
        //Write a C# program to count total number of vowels and consonants in a string.
        static void Main(string[] args)
        {
            string str = "India is My Country";
            int vowel = 0;
            int Consonants = 0;

            for(int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u') 
                {
                    vowel++;
                }
                else
                {
                    Consonants++;
                }   
            }
            Console.WriteLine("Total Count of Vowel is="+vowel);
            Console.WriteLine("Total Count of Consonant is ="+Consonants);

        }
    }
}
