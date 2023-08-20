using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.Inheritance.SingleLevelInheritance
{
    public class Animal
    {
        public void eat()
        {
            Console.WriteLine("Eating ");
        }

    }
    public class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Barking");
        }
    }
}
