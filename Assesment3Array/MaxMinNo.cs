using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.Assesment3Array
{
    public class MaxMinNo
    {
        //WAP to find the maximum and minimum value in an array.

        static void Main(string[] args)
        {
            int[] arr = new int[6] { 12, 32, 34, 2, 42, 4 };
            int n= arr[0];
            for(int i=0;i<arr.Length; i++)
            {
                if (arr[i] > n)
                {
                    n = arr[i];
                    Console.WriteLine($"Max No is:{n}");
                    break;
                }
                
            }
            
            int m = arr[0];
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < m)
                {
                    m= arr[i];
                    Console.WriteLine($"Minumum no is:{m}");
                }
                
            }
        }
    }
}
