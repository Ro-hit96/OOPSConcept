using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.ArrayProg
{
    public class EqualityOfTwoArray
    {
        static void Main(string[] args)
        {
            
                int[] array1 = new int[] { 97, 98, 69, 65, 35, 34 };//{34,35,65,69,97,98}
                int[] array2 = new int[] { 97, 98, 69, 65, 35, 34 };//{34,35,60,69,97,98}
                for (int i = 0; i < array1.Length; i++)
                {
                    for (int j = i + 1; j < array1.Length; j++)
                    {
                        if (array1[i] > array1[j])
                        {
                            int temp;
                            temp = array1[i];
                            array1[i] = array1[j];
                            array1[j] = temp;
                        }
                    }
                }
                for (int i = 0; i < array2.Length; i++)
                {
                    for (int j = i + 1; j < array2.Length; j++)
                    {
                        if (array2[i] > array2[j])
                        {
                            int temp;
                            temp = array2[i];
                            array2[i] = array2[j];
                            array2[j] = temp;
                        }

                    }
                }
                bool isvisited = true;
                if (array1.Length == array2.Length)
                {
                    for (int i = 0, j = 0; i < array1.Length || j < array2.Length; i++, j++)
                    {

                        if (array1[i] != array2[j])
                        {
                            isvisited = false;
                            break;
                        }

                    }
                }
                if (isvisited)
                {
                    Console.WriteLine("Equal");
                }
                else
                {
                    Console.WriteLine("Not equal");
                }
            

        }
    }
}
