using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.GenericCollectionn
{
    public class listGNC
    {
        static void Main(string[] args)
        {
            List<int>list2 = new List<int> { 10, 11, 12, 13, 14 };
           

            list2.Add(15);
            list2.Add(16);
            list2.Add(17);

            list2.Insert(8, 18);
            list2.Insert(9, 19);
            list2.Insert(10, 20);

            // list2.Remove(20);
            // list2.Remove(19);


            // list2.AddRange(list2);
            // list2.RemoveAt(1);
            //list2.RemoveRange(1, 2);
           // list2.Clear();
           list2.Sort();
            list2.Reverse();

            Console.WriteLine("Count (total element) " + list2.Count);
            Console.WriteLine("Capacity " + list2.Capacity);
            foreach (var item in list2)
            {
                Console.WriteLine(item);
            }

        }
    }
}
