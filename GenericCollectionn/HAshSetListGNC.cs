using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOPSConcept.GenericCollectionn
{
    public class HAshSetGNC
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();
            set.Add("Pune");
            set.Add("Mumbai");
            set.Add("Nagpur");
            set.Add("Pune");

            set.Remove("Nagpur");// remove the single element that we specified in the argument

            set.Clear();// remove all the elements

            foreach (string s in set)
            {
                Console.WriteLine(s);
            }
        }
    }
}
