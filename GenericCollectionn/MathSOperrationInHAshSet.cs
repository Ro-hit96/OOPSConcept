using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.GenericCollectionn
{
    public class MathSOperrationInHAshSet
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();
            

            set.Add("C");
            set.Add("C++");
            set.Add("c#");
            set.Add("Java");

            HashSet<string> set2 = new HashSet<string>();
            
            set2.Add("Python");
            set2.Add("C++");
            set2.Add("Angular");
            set2.Add("Java");

            //set.UnionWith(set2);// combine the result & display unique elements
            // first list matched with second & only matched elements will be displayed from both list
            //set.IntersectWith(set2);

            // compare first list with second & only unique elemetns from list1 get accepted
             set.ExceptWith(set2);

            foreach (string s in set)
            {
                Console.WriteLine(s);
            }

        }
    }
}
