using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.Sept_01
{
    public class OccOfCharcterString
    {
        static void Main(string[] args)
        {
            string str = "Hello Welcome to India";
            
            char[] ch= str.ToCharArray();
            int count = 0;

            for(int i=0;i<ch.Length; i++)
            {
                if (ch[i] == 'o')
                {
                    count++;
                }
            }
            Console.WriteLine("count occurrences of a character = " + count);
        }
    }
}
