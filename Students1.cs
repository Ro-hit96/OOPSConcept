using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept
{
    public class Students1
    {
        private int rollno;
        private string name;
        private double percentage;

        // syntax of property --RollNo is a property name
        // syntax of property --RollNo is a property name

        public int RollNo
        {
            get { return rollno; }// value is a built in keyword--> assign the value
            set { rollno = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Percentage
        {
            get { return percentage; }
            set { percentage = value; }
        }

        public string Print()
        {

            return $"Students1 {rollno} {name} {percentage}";

        }
    }   
}
