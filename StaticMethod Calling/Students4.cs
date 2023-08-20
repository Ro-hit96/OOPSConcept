using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.StaticMethod
{
    public class Students4
    {
        int x = 10;
        static int y = 20;
        public void show()
        {
            Console.WriteLine(x+" "+y);
        }
       public static void Output()
        {
            Students4 stud2 = new Students4();
            Console.WriteLine(" "+ y);
        }
    }
}
