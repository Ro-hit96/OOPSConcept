using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.Generic_Collection
{
    public class ProductMM
    {
        static void Main(string[] args)
        {
            Product Watch = new Product("Noise Halo", 5700);
            Product Headphone = new Product("One Plus", 5000);

            int result=Watch.CompareTo(Headphone);

            if (result == 1)
            {
                Console.WriteLine("Noise halo watch price greter than one plus");
            }
            if(result == -1) 
            {
                Console.WriteLine("one plus price more than noise halo");
            }
            else
            {
                Console.WriteLine("Both product has same price");
            }
        }
    }
}
