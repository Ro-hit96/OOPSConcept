using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace OOPSConcept.Generic_Collection
{
    public class Team : IEnumerable
    {
        private Player[] Players;
        public Team()
        { 
            Players = new Player[3]
            {
                new Player(2000, "Virat"),
                new Player(4000,"Sachin"),
                new Player(5000,"MSD")
            };
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
