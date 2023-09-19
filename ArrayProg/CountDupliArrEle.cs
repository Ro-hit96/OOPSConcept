using OOPSConcept.Assesment3Array;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.ArrayProg
{
    //6.	WAP to find and count total number of duplicate elements in an array.
    public class CountDupliArrEle
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            int count = 0;
            Console.WriteLine("Enter Element in Array");

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int k = 0; k < array.Length; k++)
            {
                for(int j = k + 1; j < array.Length; j++)
                {
                    if (array[k] == array[j])
                    {
                        count++;
                        break;
                    }
                }
            }
            Console.WriteLine("Total Duplicate Element count in array is " +count);
        }
    }
}
