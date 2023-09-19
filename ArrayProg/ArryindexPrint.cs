using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.ArrayProg
{
    //1.	WAP to search for a given number in an array and accordingly print the index if exists
    public class ArryindexPrint
    {
        static void Main(string[] args)
        {
            int num;
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Enter Array Number {i}");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter Number");
            num = Convert.ToInt32(Console.ReadLine());
            for (int j = 0; j < array.Length; j++)
            {
                if (array[j] == num)
                {
                    Console.WriteLine($"{num} Found at index {j} in given array");
                }

            }
        }
    }
}
