using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.Inheritance
{
    public class Employees1//Parent Class
    {
       // protected int id;
        protected string name;
        protected double salary, hra, da, ta, pf, gross,id;

        public Employees1(string name, double salary)//Constructor
        {
            this.name = name;
            this.salary = salary;
            
        }
        public virtual void CalculateSalary()
        {
            hra = salary * 0.40;
            da = salary * 0.20;
            ta = salary * 0.10;
            pf = salary * 0.12;
            gross = (salary + hra + da + ta) - pf;
        }

        public virtual string Print()
        {
            return $"Employee Gross Salary={gross}";
        }

    }
    public class Manager : Employees1//Child Class //manager is child class , Employee -base / parent class
        //Constructor
    {
        private double foodaallowance;
        public Manager(double foodaallowance, string name, double salary) : base(name, salary)//Constructor
        {
            this.foodaallowance = foodaallowance;
        }
        //polymorphism- multiple class with same behaviour but implementation is diff
        // method overrding

        public override void CalculateSalary()
        {
            hra = salary * 0.40;
            da = salary * 0.20;
            ta = salary * 0.10;
            pf = salary * 0.12;
            gross = (salary + hra + da + ta + foodaallowance) - pf;
        }
        public override string Print()
        {
            return $"Manager Gross Salary={gross}";

        }
    }
    public class SalesEmployee : Employees1//Implement Anather class -->//Child Class 
    {                                       //SalesEmployee is child class , Employee -base / parent class
        private int bonus, commission;
        public SalesEmployee(int bonus,int commission,double foodaallowance, string name, double salary):base(name, salary) 
        {
            this.bonus = bonus;
            this.commission = commission;   
        }
        //polymorphism- multiple class with same behaviour but implementation is diff
        // method overrding
        public override void CalculateSalary()
        {
            hra = salary * 0.40;
            da = salary * 0.20;
            ta = salary * 0.10;
            pf = salary * 0.12;
            gross = (salary + hra + da + ta +bonus+commission) - pf;
            
        }
        public override string Print()
        {
            return $"Sales Employee Gross Salary={gross}";

        }
    }
}
