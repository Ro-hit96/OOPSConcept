using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept
{
    public class Date
    {
        private int day, year; //Member of a class // Declaration of data members
        private string month;

        //Method-This Method assign value of each data member
        //Method Defination
        public void AcceptDate(int dd, string mm, int yy)
        {
            day = dd;
            month = mm;
            year = yy;
        }
        public string PrintDate()
        {
            return $"Date:{day}/{month}/{year}";
        }

       


    }
}
