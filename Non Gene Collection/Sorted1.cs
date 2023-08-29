using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace OOPSConcept.Collection
{
    public class Sorted1
    {
        static void Main(string[] args)
        {
            SortedList so=new SortedList();
            so.Add(101, "Compu");
            so.Add(102, "Sci");
            so.Add(103, "Phy");
            so.Add(104, "Chemi");

            so.Remove(101);

            foreach(int i in so)
            {
                Console.WriteLine(i);
            }
        }
    }
}
