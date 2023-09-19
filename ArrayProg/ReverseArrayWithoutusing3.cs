using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.ArrayProg
{
    public class ReverseArrayWithoutusing3
    {
        //12WAP to reverse the array itself, don’t print array in reverse
        //– I want current array reverse. Means e.g. arr[] = [3, 90, 45, 29, 37, 78]
        //so your same array must be [78, 37, 29, 45, 90, 3]
        //without using temporary array.

        static void Main(string[] args)
        {
            int[] array = new int[] { 78, 37, 29, 45, 90, 3 };
            for(int i = 0; i <= array.Length; i++)
            {
                for(int j = i + 1; i < array.Length; j++)
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
                Console.WriteLine(array[i]);
            }
        }
    }
}
