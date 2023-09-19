using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.ArrayProg
{
    public class NegativeNoinArray
    {
        // 3.	WAP to print all negative elements in an array and also count total number of negative elements in an array.
        static void Main(string[] args)
        {
            int count = 0;
            int num;
            int[]array=new int[20];
            Console.WriteLine("Enter size in arrary");
            num=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Element in arary");
            for(int i = 0; i < num; i++)
            {
                array[i]=Convert.ToInt32(Console.ReadLine());
            }
            for (int j = 0; j < num; j++)
            {
                if (array[j] < 0)
                {
                    Console.WriteLine("Negative No is"+array[j]);
                    count++;
                }
            }
            Console.WriteLine("Count is "+count);

        }
    }
}
