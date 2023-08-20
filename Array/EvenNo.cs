using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.Array
{
    internal class EvenNo
    {
        static void Main(string[] args)
        {
            int[] even = new int[5];
            int[] odd = new int[5];
            Console.WriteLine("Enter Numbers");

            for (int i=0;i< even.Length; i++)
            {
                even[i]=Convert.ToInt32(Console.ReadLine());
            }
            for(int k=0;k<odd.Length;k++)
            {
                odd[k] = Convert.ToInt32(Console.ReadLine());
            }


           

            
        }
    }
}
