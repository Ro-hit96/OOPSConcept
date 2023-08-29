using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.Generic_Collection
{
    public class Program
    {
        static void Main(string[] args)
        {
            Team team = new Team();
            foreach (var item in team)
            {
                Console.WriteLine(item);
            }
        }
    }
}
