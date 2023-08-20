using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept
{
    public class Product
    {
        private int id;
        private string name;
        private double price;

        public Product(int id,string name,double price)
        {
            this.id = id;
            this.name = name;
            this.price = price;
        }

        public void  Discount(double discamount)
        {
            price = (price * (discamount / 100));
        }
        public string Print()
        {
            return $"product id is {id} Product name is {name} Product Price is {price} Discount amount is ";
        }

    }
}
