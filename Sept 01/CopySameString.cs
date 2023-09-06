using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.Sept_01
{
    public class CopySameString
    {
        static void Main(string[] args)
        {
            // C# program to demonstrate the example of String.Copy() method
            string str;
            string str2;
            Console.WriteLine("Enter String");  
            str=Console .ReadLine();
            str2 = string.Copy(str);
            Console.WriteLine("Oringnal String=" + str);
            Console.WriteLine("Copy String=" + str2);
            
        }
    }
}
