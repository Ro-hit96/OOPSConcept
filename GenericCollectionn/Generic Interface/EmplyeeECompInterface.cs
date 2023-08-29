using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.GenericCollectionn.Generic_Interface
{
    public class EmplyeeECompInterface
    {
        public string EName { get; set; }
        public int ESalary { get; set; }

    }
    public class CheckSalary : IComparer<EmplyeeECompInterface>
    {
        public int Compare(EmplyeeECompInterface x, EmplyeeECompInterface y)//x-->E1 && y-->E2
        {
            if(x.ESalary> y.ESalary)
            {
                return 1;
            }
            else if(x.ESalary < y.ESalary)
            {
                return -1;
            }
            else
            {
                return 0;
            }
            
        }
    }

    public class Emplyee
    {
        static void Main(string[] args)
        {
            EmplyeeECompInterface E1=new EmplyeeECompInterface {EName="Rohit",ESalary=50000};
            EmplyeeECompInterface E2 = new EmplyeeECompInterface { EName = "Amit", ESalary = 50000 };

            CheckSalary E3=new CheckSalary();
            int result=E3.Compare(E1, E2);

            if (result == 1)
            {

                Console.WriteLine("Rohit has higher Salary");
            }
            else if (result == -1)
            {
                Console.WriteLine("Rohit Has Lower Salary");
            }
            else
            {
                Console.WriteLine("Both Emoloyee Has Same Salary");
            }
        }
    }

    
}
