using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.ArrayProg
{
    public class SecondSmallestNo
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            int min=int.MaxValue;
            int SecMin=int.MinValue;
            Console.WriteLine("Enter No");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
          for(int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    SecMin = min;
                    min= array[i];
                }
                else if (array[i] < SecMin && array[i] != min)
                {
                    SecMin = array[i];
                }
            }
            Console.WriteLine("Second Min array element is"+SecMin);
        }
    }
}
