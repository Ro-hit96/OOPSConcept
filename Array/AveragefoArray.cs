using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.Array
{
    public class AveragefoArray
    {
        
        public static int Average(int[] array)
        {
            int cnt = 0; int sum = 0; int avg;
            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Enter Num");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i = 0; i < array.Length; i++)
            {
                sum = sum + array[i];
                cnt++;
            }
            avg= sum / cnt;
            return avg;

        }

        public static double AverageA(double[] array)
        {
            int cnt = 0; double sum = 0; double avg;
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Enter Num");
                array[i] = Convert.ToDouble(Console.ReadLine());
            }
            for (int i = 0; i < array.Length; i++)
            {
                sum = (double)sum + array[i];
                cnt++;
            }
            avg = (double)sum / cnt;
            return avg;
        }
        static void Main(string[] args)
        {
            int[] arrar1 = new int[3];
            Console.WriteLine(Average(arrar1));
            double[] array2=new double[3];
            Console.WriteLine(AverageA(array2));
            Console.WriteLine(AverageA(array2));
        }


    }
}
