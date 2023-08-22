using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept._2D_Array
{
    public class UniqueEleArry
    {
        static void Main(string[] args)
        {
            int[] arr = new int[6];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Enter No ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i< arr.Length; i++)
            {
                int count = 0;
                for(int j = 0; j < arr.Length; j++)
                {
                    if (arr[j] == arr[i])
                    {
                        count++;
                    }
                }
                if (count == 1)
                {
                    Console.WriteLine($"{arr[i]} is a unique element in arr");
                }
            }
        }
    }
}
