using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.Assesment3Array
{
    public class SearchNo
    {
        static void Main(string[] args)
        {
           // 1.WAP to search for a given number in an array and accordingly print the index if exists

            int[] arr = new int[6]{ 10, 23, 24, 7, 24, 24 };
            Console.WriteLine("Enter Number");
            int num = Convert.ToInt32(Console.ReadLine());
            int index = -1;
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == num)
                {
                    index = i;
                    break;
                }
            }
            if (index != -1)
            {
                Console.WriteLine($"tHe num is {num} is found at index{index}");
            }
            else
            {
                Console.WriteLine($"The num is {num} is not found in array");
            }
        }
    }
}
