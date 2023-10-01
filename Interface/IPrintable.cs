using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.Interface
{
    public interface IPrintable
    {
        void print();
        //bydefault public and abstract
        void display();
    }
    public class User : IPrintable
    {
        public void print()
        {
            Console.WriteLine("Print Method");
          
        }
        public void display()
        {
            Console.WriteLine("Display Method");
        }
    }
    public class UserMMInter
    {
        static void Main(string[] args)
        {
            User u1= new User();
            u1.print();
            u1.display();
        }
    }
}
