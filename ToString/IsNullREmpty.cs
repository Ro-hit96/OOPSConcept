using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.ToString
{
    public class IsNullREmpty
    {
        static void Main(string[] args)
        {
            string str = " ";
            if (string.IsNullOrEmpty(str))
            {
                Console.WriteLine("String is Empty");
            }
            Console.WriteLine(str);
            Console.WriteLine("Enter The Name");
            string name=Console.ReadLine();
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Name is req");

            }
            else
            {
                Console.WriteLine("Hello"+name);
            }
        }
    }
}
