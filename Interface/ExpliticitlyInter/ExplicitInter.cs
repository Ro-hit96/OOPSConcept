using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.Interface.ExpliticitlyInter
{
    public class ExplicitInter
    {
        public interface Icustomer
        {
            string Display();
        }
        public interface Iorders
        {
            string Display();
        }
        public class Transaction : Icustomer, Iorders
        {
            string Icustomer.Display()
            {
                return "Customer Details";
            }
            string Iorders.Display()
            {
                return "Order Details";
            }
        }
    }
}
