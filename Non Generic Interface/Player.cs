using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace OOPSConcept.Generic_Collection
{
    public class Player
    {
        private int runs;
        private string name;

        public Player(int Runs,string Name)
        {
            this.runs = Runs;
            this.name = Name;
        }
        public override string ToString()
        {
            return $"{runs}-->{name}";
        }
    }
}
