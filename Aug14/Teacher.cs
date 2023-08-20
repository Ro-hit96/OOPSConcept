using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace OOPSConcept.Aug14
{
    public class Teacher
    { 
        protected int tid;
        protected string name;
      public  Teacher(int tid,string name)//Parent
        {
            this.tid = tid;
            this.name = name;
        }

        public virtual string Display()
        {
            return $"Stu id is {tid} name is {name} ";
        }    

    }

    public class TempTeacher : Teacher//cChild
    {
        protected int wokinghr, salary;
        
        public TempTeacher(int workinghr, int salary,int tid,string name) : base (tid, name)
        {
            this.wokinghr = workinghr;
            this.salary = salary;
        }
        public override string Display()
        {
            return $"teacher id is {tid} name is {name} tsalary {salary} temp Teacher wokinghr {wokinghr}";
        }


    }
}
