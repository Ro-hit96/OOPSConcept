using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.Exam
{
    internal class HarshadNo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Num");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int temp = num;

            while(num!=0)
            {
              int  rem = num % 10;
                 sum = sum + rem;
                num = num /10;
            }
            if (temp%sum == 0)
            {
                Console.WriteLine("Harshad");
            }
            else
            {
                Console.WriteLine("No is non  Harshad");
            }


        }
    }
}
