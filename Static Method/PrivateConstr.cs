using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.Static_Method
{
    static class PrivateConstr
    {
         static int no;
         static string name;
         


        static PrivateConstr()
        {
            Console.WriteLine("Hii");
            no = 10;
            no = 11;
        }

        public static int Display()
        {


            no++;
            return no;
        }
    }

    public class PrivateConstructor
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PrivateConstr.Display());

        }
    }
}
