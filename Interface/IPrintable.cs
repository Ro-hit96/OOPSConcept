using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.Interface
{
    public interface IPrintable
    {
        string print();//bydefault public and abstract
    }
    public class User : IPrintable
    {
        public string print()
        {
            return "User Details";
        }
    }
}
