using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.Assesment3Array
{
    public class NegNo
    {
     //WAP to print all negative elements in an array and also count total number of negative elements in an array.

        static void Main(string[] args)
        {
            int[] NegaNo = new int[10];
            int Count = 0;
            Console.WriteLine("Enter Number");
            for(int i = 1; i < NegaNo.Length; i++)
            {
                NegaNo[i]=Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 1; i < NegaNo.Length; i++)
            {
                if (NegaNo[i] < 0)
                {
                    Console.WriteLine($"Negative no is {NegaNo[i]} ");
                    Count++;
                }
            }
            Console.WriteLine($"Count of Negative No is {Count}");

        }
 
    }
}
