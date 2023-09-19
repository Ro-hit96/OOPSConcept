using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOPSConcept.ArrayProg
{
    public class EvenOddSepArray
    {
        // 4.	WAP to put even and odd elements of array in two separate arrays.
        static void Main(string[] args)
        {
            int[] array = new int[5];
            int[] even=new int[10];
            int[] odd=new int[10];
            Console.WriteLine("Enter No");

            for (int i = 0; i < array.Length; i++)
            {
                
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Actual Array ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("" + array[i]);
            }
            Console.WriteLine("\n");
         
            Console.WriteLine("Even No Array");
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    even[i] = array[i];
                 
                    Console.Write("" + even[i]);
                }
            }
            Console.WriteLine("\n");
            Console.WriteLine("Odd Array");
  
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] %2 != 0)
                {
                    odd[i] = array[i];
               
                    Console.Write("" + odd[i]);
                }
            }
        }
    }
}
