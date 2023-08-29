using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.GenericCollectionn
{
    public class ConvertArraytoList
    {
        static void Main(string[] args)
        {
            //int[] arr = { 1, 2, 3, 4, 5};
            //List<int> list = new List<int>();
            //list.AddRange(arr);
            //foreach (int i in list)
            //{
            //    Console.WriteLine(i);
            //}

            //Using COnstructor
            // int[] arr1 = { 11, 12, 13, 14, 15 };
            // List<int> list2 = new List<int>(arr1);//Here i use constructor (arr1)

            //foreach (int i in list2)
            // {
            //     Console.WriteLine(i);
            // }

            // Using Enumerable .TOList Method()
            int[] arr32 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11};
            List<int> list4 = new List<int>();

          // List<int>list=arr32.OfType<int>().ToList();
            List<int> list2=arr32.Cast<int>().ToList();

            Console.WriteLine(String.Join(",",list2));
            

        }
    }
}
