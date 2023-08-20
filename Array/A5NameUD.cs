using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.Array
{
    public class A5NameUD
    {
        static void Main(string[] args)
        {
            string[] s = new string[5];
            Console.WriteLine("Enter Names");

            for(int i = 0; i < s.Length; i++)
            {
                s[i]=Console.ReadLine();
            }
            for(int i = 0; i < s.Length; i++)
            {
                Console.WriteLine($"Name of [{i}]={s[i]}");
            }
        }
    }
}
