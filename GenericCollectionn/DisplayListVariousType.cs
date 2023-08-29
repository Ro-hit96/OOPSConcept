using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.GenericCollectionn
{
    public class DisplayListVariousType
    {
        
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(40);
            list.Add(50);
            Console.WriteLine("Count of ELement is"+list.Count);

            /*foreach (int i in list)//Frist Way
            {
                Console.WriteLine(i);
            }*/

            //  list.ForEach(i => Console.WriteLine(i));// Second Way

            /* for(int i = 0; i < list.Count; i++)   //Third Way
             {
                 Console.WriteLine(list[i]);
             }*/

            // list.ForEach(Console.WriteLine); Fourth Way

            Console.WriteLine(string.Join(",", list)) ; //Fifth Way


        }
    }
}
