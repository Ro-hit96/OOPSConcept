using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.ArrayProg
{
    public class UniqueElementINArry
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Console.WriteLine("Enter Array Element");
   
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            for(int i = 0; i < array.Length; i++)
            {
                bool isvisited = true;
                int count = 1;
                for(int k = i - 1; k >= 0; k--)
                {
                    if (array[k] == array[i])
                    {
                        isvisited = false;
                        break;
                    }
                }
                if (isvisited = false)
                {
                    for(int j = i + 1; j < array.Length; j++)
                    {
                        if (array[j] == array[i])
                        {
                            isvisited = false;
                            count++;
                        }
                    }
                    if (count == 1)
                    {
                        Console.WriteLine($"Unique Element in Array are {array[i]}");
                    }
                }

            }
        }
    }
}
