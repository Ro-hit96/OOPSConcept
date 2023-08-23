using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;//

namespace OOPSConcept.Collection
{
    public class ArrayListP
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 2,43,2,13};
            ArrayList list=new ArrayList();
            list.Add(10);
            list.Add(20);
            list.Add(30);

            list.Insert(8, 5);
            list.AddRange(arr);//add multiple value at a time
            //Remove the element based on index
            list.Remove(2);//Remove Element based on index
            // remove multiple elements at once



            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
        }
    }
}
