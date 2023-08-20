using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.Aug14
{
    public class Bike
    {
        protected int ModelNo;
        protected string BName;
        protected string Biketype1;
        protected string Biketype2;
        public Bike(int ModelNo, string bName)
        {
           this.ModelNo = ModelNo;
           this. BName = bName;
            Biketype1 = "MofetBike";
            Biketype2 = "SportBike";

        }
        public virtual void GetBInfo()
        {
            Console.WriteLine("Model no is"+ModelNo);
            Console.WriteLine("Bike Name is"+BName);
        }
    }
    public class Mofet : Bike

    {
        protected int price;
        public Mofet(int price,int modelno,string BName):base (modelno,BName )
        {
            this.price = price;
        }
        public override void GetBInfo()
        {
            base.GetBInfo();
            Console.WriteLine("MofetBike"+Biketype1);
        }
    }
}
