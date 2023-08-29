using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.Non_Generic_Interface
{
    public class Player12:IComparable
    {
        private int id;
        private string pname;
        private int run;
        public Player12(int Id,string Pname,int Run )
        {
            this.id = Id;
            this.pname = Pname;
            this.run = Run;    
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return pname;
        }
    }
}
