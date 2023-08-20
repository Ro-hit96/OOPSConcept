using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.Assesment3Array
{
    public class DuplicateNo
    {
        static void Main(string[] args)
        {
            int[] arr=new int[6] { 12, 34, 32, 32, 12, 4};
            int dup = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                int Count = 1;
                bool isVisited=false;
                for(int k=i-1;k>0;k--)
                {
                    if (arr[k] == arr[i])
                    {
                        isVisited = true;
                        break;
                    }
                }
                if (isVisited = false)
                {
                    for(int j = i + 1; j < arr.Length; j++)
                    {
                        if (arr[j] == arr[i])
                        {
                            Count++;
                        }
                    }
                    if (Count > 1)
                    {
                        dup++;
                        Console.WriteLine($"Element{arr[i]}has {Count} duplicated");
                    }
                }
            }
            Console.WriteLine($"The total duplicate element is :{dup}");
        }
    }
}
