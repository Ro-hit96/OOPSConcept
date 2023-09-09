using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.Sept_01
{
    public class Join2String
    {
        //WC to joined two string
        //We can join two strings in C# using the Concat() method.
        static void Main(string[] args)
        {
            /*string str = "C# Programing";
            string str2 = "OOPS Programing";

            //print String
            Console.WriteLine("First String=="+str);
            Console.WriteLine("Second String==" + str2);

            string JoinString = string.Concat(str," + " +str2);

            Console.WriteLine("Join String Is"+JoinString);*/

            Console.WriteLine("Enter String First");
            string str=Console.ReadLine();
            Console.WriteLine("Enter Second String");
            String str2=Console.ReadLine();

            string joinString = string.Concat(str," + " +str2);
            Console.WriteLine(joinString);

            int length = str.Length;
            int lenght2 = str2.Length;
            Console.WriteLine("Length of First String is="+length);
            Console.WriteLine("Length of Second String is="+ lenght2);

        }
    }
}
