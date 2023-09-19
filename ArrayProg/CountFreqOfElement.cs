using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.ArrayProg
{
    // 9.	WAP to count frequency of each element in an array.
    public class CountFreqOfElement
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 2, 3, 2, 4, 1, 4, 1, 6, 7, 8 };

            //int count = 0;
            for (int i = 0; i < num.Length; i++)
            {
                int count = 1;
                int count2 = 1;
                bool isvisited = false;
                for (int k = i - 1; k >= 0; k--)
                {
                    if (num[k] == num[i])
                    {

                        isvisited = true;
                        break;
                    }
                }
                if (isvisited == false)
                {
                    for (int j = i + 1; j < num.Length; j++)
                    {
                        if (num[i] == num[j])
                        {
                            count++;
                            count2--;
                        }

                    }
                    if (count > 1)
                    {
                        Console.WriteLine(count + "times" + num[i]);

                    }
                    if (count == 1)
                    {
                        if (count2 == 1)
                        {
                            Console.WriteLine(count2 + " times " + num[i]);
                        }

                    }
                }
            }
        }   }
    
}
