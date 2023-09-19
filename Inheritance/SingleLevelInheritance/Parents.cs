using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.Inheritance.SingleLevelInheritance
{
    public class Parents
    {
        int x = 10;
         protected string name;
        public Parents(string name)
        {
            Console.WriteLine("This is Parent Class"+name);
        }
        /*public void  show()
        {
            Console.WriteLine("This is Parent Class");
        }*/
    }
    class Child : Parents
    {
        public Child():base("Constrs Child")
        {
            Console.WriteLine("Constructor Child");
        }

        /*int x = 100;
        public void show()
        {
            Console.WriteLine("Child Class");
        }*/
    }

    public class ParentMM
    {
        static void Main(string[] args)
        {
            /*Parents p=new Child();
            p.show();*/

            Child c = new Child();

        }
    }
}
