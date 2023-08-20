using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.Default_Parameter
{
    public class Car
    {
        private string companyname, modelname;
        private int cost;

        public Car(string modelname,int cost, string companyname="Honda")
        {
            this.companyname = companyname;
            this.modelname = modelname; 
            this.cost = cost;
        }

        //public void Accept(String companyname,String modelname,int cost)
        //{

        //} 
        public string Print()
        {
            return $"{modelname},{cost},{companyname}";
        }
    }
}
