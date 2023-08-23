using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.ToString
{
    public class Remove_MethSB
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("Hello to all");
            Console.WriteLine(sb);

            sb.AppendLine("Good Morning");
            Console.WriteLine(sb);

            sb.Remove(3, 4);
            Console.WriteLine(sb);

            sb.Replace('l', 'L');
            Console.WriteLine(sb);
        }
        

    }
}
