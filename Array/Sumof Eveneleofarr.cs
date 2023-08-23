using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.Array
{
    public class Sumof_Eveneleofarr
    {   
        //wc to create int type of aaray and calculate the sum of the even element from the array
        static void Main(string[] args)
        {
            
            int sum = 0;
            Console.WriteLine("Enter Num");
            int[] even = new int[5];
            for (int i = 0; i < even.Length; i++)
            {
                even[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i=0; i < even.Length; i++)
            {
                if (even[i] % 2 == 0)
                {
                     sum = sum+even[i];
                   
                }
               
            }
            Console.WriteLine($"Sum of Even Element is{sum}");


        }
    }
}
