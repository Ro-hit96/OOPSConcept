using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OOPSConcept.Interface.ExpliticitlyInter.ExplicitInter;

namespace OOPSConcept.Interface.ExpliticitlyInter
{
    internal class ExpliMM
    {
        static void Main(string[] args)
        {
            Icustomer c = new Transaction();
            Console.WriteLine(c.Display());

            Iorders o = new Transaction();
            Console.WriteLine(o.Display());
        }
    }
}
