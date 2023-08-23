using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.Array
{
    public class PrimeEleOfArry
    {
        //WAC to display Prime Element of Array
        static void Main(string[] args)
        {
            int[] arr = new int[6];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter Num");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
                
            for(int i = 0; i < arr.Length; i++)
            {
                bool isprime = true;
                for(int j = 2; j < arr[i]; j++)
                {
                    if (arr[i] % j == 0)
                    {
                        isprime=false;
                        break;
                    }
                }
                if (isprime)
                {
                    Console.WriteLine($"Primee Element of array is {arr[i]}");
                }
            }
        }
    }
}
