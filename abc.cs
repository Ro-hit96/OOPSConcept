using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept
{
    internal class abc
    {
        public static void a()
        {
            Console.WriteLine("first method");
        }
        public void b(int i)
        {
            Console.WriteLine(i);
            b(i);

        }

    }
}
