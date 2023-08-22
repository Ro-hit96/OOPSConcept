using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept._2D_Array
{
    public class HighestEleArry
    {
        public static void PrintHighestA(int[] arr,int arr_size)
        {
            int i, First, Second;
            //There should be atleast two element
            if (arr_size < 2)
            {
                Console.WriteLine("Invalid Input");
                return;
            }
            First = Second = int.MinValue;
            for (i = 0; i < arr_size; i++)
                //if current element is smaller than first the update both first and second
            {
                if (arr[i] > First)
                {
                    Second = First;
                    First = arr[i];
                }
                //if arr[i]is in between first and sec then update sec
                else if (arr[i]>Second && arr[i]!=First)
                    Second = arr[i];
            }
            if (Second == int.MinValue)
                Console.WriteLine("There is no second largest element + \n");
            else
                Console.WriteLine("The Sec Largest ele  " + "is" + Second);

        }

        static void Main(string[] args)
        {
            int[] arr = { 12, 34, 5, 54, 43, 3, 2, };
            int n = arr.Length;
            PrintHighestA(arr, n);
        }
    }
}
