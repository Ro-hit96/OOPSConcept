using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.StriingProg
{
    public class AnagramProg
    {
        static void Main(string[] args)
        {
            string str = "Listen";
            string str2 = "silent";

            
            char[]ch=str.ToLower().ToCharArray();
            char[]ch2=str2.ToLower().ToCharArray();
            Array.Sort(ch);
            Array.Sort(ch2);

            string str3 = new string(ch);
            string str4 = new string(ch2);
           

            if (str3 == str4)
            {
                Console.WriteLine("anagram Program");
            }
            else
            {
                Console.WriteLine("Not Anagram Program");
            }

        }

    }
}
