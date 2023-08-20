using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOPSConcept.Assesment3Array
{
    public class EvenOddNo2SeptNo
    {
       // WAP to put even and odd elements of array in two separate arrays.

        static void Main(string[] args)
        {
            int[] arr = new int[6] { 2, 65, 34, 23, 13, 14 };
            int[] EvenArray;
            int[] OddArray;

            int EvenCount = 0;
            int OddCount = 0;

            foreach (int num in arr)
            {
                if (num % 2 == 0)
                {
                    EvenCount++;
                }
                else
                {
                    OddCount++;
                }
            }
            EvenArray=new int[EvenCount];
            OddArray=new int[OddCount];

            int EvenIndex = 0;
            int OddIndex = 0;
            foreach (int num in arr)
            {
                if (num % 2 == 0)
                {
                    EvenArray[EvenIndex]=num;
                    EvenIndex++;
                }
                else
                {
                    OddArray[OddIndex]=num;
                    OddIndex++;
                }
            }
            Console.WriteLine("Even Element:\n");
            foreach (int evennum in EvenArray)
            {
                Console.WriteLine(evennum);
            }
            Console.WriteLine("Odd Element:\n");
            foreach (int oddnum  in OddArray)
            {
                Console.WriteLine(oddnum);
            }


        }
    }
}
