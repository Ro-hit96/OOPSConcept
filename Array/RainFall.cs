using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.Array
{
    public class RainFall
    {
        static void Main(string[] args)
        {
            int[] rainfall = new int[7];
            Console.WriteLine("Enter RainFall vallue");

            for (int i = 0; i<rainfall.Length; i++)
            {
                
                rainfall[i]=Convert.ToInt32(Console.ReadLine());
              
            }
            Console.WriteLine("Print all Rainfall");
            for(int i=0; i < rainfall.Length; i++)
            {
                Console.WriteLine($"Day[{i}]={rainfall[i]}mm");
            }
        }
        
    }
}
