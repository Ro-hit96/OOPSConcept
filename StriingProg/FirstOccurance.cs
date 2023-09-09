using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.Sept_01
{
    public class FirstOccurance
    {
        static void Main(string[] args)
        {
            string str = "iRohit Survasei";
             int index=str.LastIndexOf('i');

            // Console.WriteLine(str.IndexOf('i')); First Index Print
            Console.WriteLine(str.LastIndexOf('i'));



        }
    }
}
