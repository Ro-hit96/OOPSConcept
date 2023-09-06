using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.Array
{
    public class PNegativeNo
    {
        static void Main(string[] args)
        {
            int[] NegNo = new int[10];
            int Count=0;

            Console.WriteLine("Enter Negative Num");
            for (int i = 1; i < NegNo.Length; i++) 
            {
                NegNo[i]=Convert.ToInt32(Console.ReadLine());
            }
            for(int i = 1; i < NegNo.Length; i++)
            {
                if (NegNo[i] < 0)
                {
                    
                    Console.WriteLine($"Negative No is{NegNo[i]}");
                    Count++;
                }


            }
            Console.WriteLine($"Count of Negative Is {Count}");


        }
    }
}
