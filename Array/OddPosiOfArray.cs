using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.Array
{
    public class OddPosiOfArray
    {
        //WC to create array & display odd position from array

        static void Main(string[] args)
        {
            
            int[] odd = new int[5];
           
            for (int i = 0; i < odd.Length; i++)
            {
                Console.WriteLine($"Enter Num{i}index");
                odd[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i = 0; i < odd.Length; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine($"odd position of array={odd[i]}");
                }
            }
        }
    }
}
