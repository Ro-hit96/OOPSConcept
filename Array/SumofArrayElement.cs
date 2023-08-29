using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.Array
{
    public class SumofArrayElement
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Num");
            int[] arr=new int[5];
            int sum=0;
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }
            Console.WriteLine(sum);
        }
    }
}
