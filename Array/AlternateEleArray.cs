using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.Array
{
    public class AlternateEleArray
    {
        //WAC to display alternate element from the array
        static void Main(string[] args)
        {
          
            int[] arr = new int[5];

            for( int i=0;i < arr.Length;i++)
            {
                Console.WriteLine("Enter Num");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i=0;i<arr.Length;i=i+2)
            {
                Console.WriteLine($"Alternate no is{arr[i]}");
            }
            
        }
    }
}
