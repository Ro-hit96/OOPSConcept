using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.Sept_01
{
    public class MaxNoFromArray
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            
            for(int i = 0; i < arr.Length; i++)
            {   
                int max = arr[i];
                if (arr[i] > max)
                {
                    Console.WriteLine(arr[i]);
                }

            }           
        }
    }
}
