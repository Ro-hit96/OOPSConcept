using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.Sept_01
{
    public class SplittwoString
    {
        static void Main(string[] args)
        {
            string str = "Hellow$World";
            string []str2 = str.Split('$');
            foreach (var item in str2)
            {
                Console.WriteLine(item);
            }
        }
    }
}
