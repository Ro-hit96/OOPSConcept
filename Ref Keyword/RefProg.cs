using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.Ref_Keyword
{
    public class RefProg
    {
        static void swap(ref int a,ref int b)
        {
            int temp;//value at that address
            temp = a;//value at that address
            a = b;
            b=temp;
        }

        static void Main(string[] args)
        {
            //value must be assign before we pass to parameter /must have a value in variable
            int a = 100, b = 200;
            swap(ref a,ref b);
            Console.WriteLine($"a={a},b={b}");
        }
    }
}
