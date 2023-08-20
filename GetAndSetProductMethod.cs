using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept
{
    public class GetAndSetProductMethod
    {
        private int code;
        private string name;
        private double price;

        public int Code
        {
            get { return code; }
            set { code = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public string Print()
        {
            return $"Product {code},{name},{price}";
        }

    }
}
