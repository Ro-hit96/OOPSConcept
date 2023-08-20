using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept
{
    public class Employee
    {
        private int eid;
        private string name;
        private double salary, hra, da, ta,pf, gross;
        private static int count;

        //public Employee() 
        //{
        //    eid = 0;
        //    name = "";
        //    salary = 0.0;
        //}
        public Employee(string name,double salary)
        {
            count++;
            this.eid = count;
            this.name = name;
            this.salary = salary;
        }
        public static int GetEmpCount()
        {
            return count;
        }

    
    //public void Accept(int id,string name,double salary)
    //{
    //        this.eid = id; 
    //        this.name = name;
    //        this .salary = salary;
    //}
    public void CalculteSalary()
        {
            hra = salary * 0.40;
            da = salary * 0.20;
            ta = salary * 0.10; 
            pf = salary * 0.12;
            gross=(salary+hra+da+ta)-pf;
        }

        
        public string Print()
        {
            return $"eid={eid},Name={name},Basic Salary={salary},Gross={gross},Count is {count}" ;
        }
       

    }
}
