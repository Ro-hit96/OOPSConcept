using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.Exam
{
    internal class AverageOfFactor
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Num");
            int num=Convert.ToInt32(Console.ReadLine());
            int count = 0;
            int sum = 0;
            while(num>0)
            {
                int rem = num % 10;
                count++;
                 sum = sum + rem;
                num = num / 10;
            }
            int avg = sum / count;
            Console.WriteLine(avg);


        }
    }
}
