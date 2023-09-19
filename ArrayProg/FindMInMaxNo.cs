using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.ArrayProg
{
    public class FindMInMaxNo
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            int min =1 ;
            int max =0;
            Console.WriteLine("Enter Number");
            for(int i = 0;i<array.Length ; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
                 else if (array[i]<min)
                {
                    min = array[i];
                }
            }
            Console.WriteLine("Minimum Element in Array"+min);
            Console.WriteLine("Maximum Element in Array"+max);
        }
    }
}
