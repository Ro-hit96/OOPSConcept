using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.Sept_01
{
    public class FacrorialofNo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int a=Convert.ToInt32(Console.ReadLine());
            int fact=1;
            int i = 1;

            while (i <= a)
            {
                fact = fact * i;
                i++;
            }
            Console.WriteLine("Factorial No"+fact);

        }
    }
}
