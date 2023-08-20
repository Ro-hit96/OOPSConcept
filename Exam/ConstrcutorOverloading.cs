using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.Exam
{
    public class ConstrcutorOverloading
    {
        private int Eid;
        private string Name;
        private string Add;
        private long mobno;
        private int age;
        private double salary;
        public ConstrcutorOverloading()
        {
            Eid= 0;
            Name = "Rohit";
            Add = "Akurdi";
        }
        public ConstrcutorOverloading(long mobno,int age)
        {
            this.mobno = mobno;
            this.age = age;
        }
        public ConstrcutorOverloading(double salary)
        {

            this.salary = salary;

        }

        public string Print()
        {
            return $"Employee id {Eid}\n Name is {Name} \n Address is {Add}\n Mob No {mobno}\n Age is {age} \n Salary is{salary}";
        }
    }
}
