using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.Static_Method
{
    public class Car
    {
        private string model;
        private int totalcarsold;
        public Car(string model, int totalcarsold)
        {
           model = "I20";
           totalcarsold = 25;
        }
        public string Print()
        {
            return $"{model},{totalcarsold}";
        }

    }
}
