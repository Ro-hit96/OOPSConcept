using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;

namespace OOPSConcept.Generic_Collection
{
    public class Product:IComparable
    {
        private string pname;
        private int Price;
        public Product(string Pname,int Price)
        {
            this.pname = Pname;
            this.Price = Price;
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
            Product p= (Product)obj;

            if (this.Price > p.Price)
            {
                return 1;
            }
            else if (this.Price < p.Price)
            {
                return -1;
            }
            else
            {
                return 0;
            }
            
        }
        public override string ToString()
        {
            return $"{pname}-->{Price}";
        }
    }
}
