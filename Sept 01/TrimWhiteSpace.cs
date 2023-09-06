using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.Sept_01
{
    public class TrimWhiteSpace
    {
        static void Main(string[] args)
        {
            String str = "India  ";
            string str2 = "   Is My Country     ";

            //Console.WriteLine(str2.Trim());//Clear space from strat and End
            //Console.WriteLine(str.TrimEnd());//Clear space only end of string
            Console.WriteLine(str2.TrimStart());
        }
    }
}
