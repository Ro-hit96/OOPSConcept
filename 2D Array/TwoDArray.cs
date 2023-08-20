using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept._2D_Array
{
    public class TwoDArray
    {
        static void Main(string[] args)
        {


            /*syntax of 2D array
             here 3 is row size and 4 is column size*/
            int[,] arr = new int[4, 5]
            {
            { 12,123,12,13,13},
            { 123,24,55,34,45,},
            {54,45,66,56,54 },
            {65,56,65,665,67}

            };
            // nested for loop to display the 2D array
            for (int row = 0; row < arr.GetLength(0); row++)
            {
                for(int col = 0; col < arr.GetLength(1); col++)
                {
                    Console.Write($"arr[{row},{col}]={arr[row, col]}");
                }
                Console.WriteLine("\n");
            }


        }
    }
}
