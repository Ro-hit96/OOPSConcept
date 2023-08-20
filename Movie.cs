using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept
{
    public class Movie
    {
        private int mid;
        
        private string mname, tickettype;
        private int tprice;
        private int nooftickets;
        private int num;
        private int totalcost;
        private int avialableticket;
       
        public Movie(int mid,string mname,int tprice,int nooftickets)
        {
            this.mid=mid;
            this.mname=mname;
            this.tprice = tprice;
            this.nooftickets=nooftickets;
        }
       
        public void FindAvilabeTickets()
        {
            Console.WriteLine("Enter No Ticket to book");
            num=int.Parse(Console.ReadLine());
            if(nooftickets>num)
            {
                avialableticket = nooftickets - num;
                this.Calulateticketcost();
            }
            else
            {
                Console.WriteLine("insufficient Tickets");
            }
        }
        
        public void Calulateticketcost()
        {
            Console.WriteLine("1.Silver-100rs\n 2.Gold-200rs \n 3.Platinum=300rs");
            Console.WriteLine("Enter Type");
            int choice=int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    tickettype = "Silver";
                    tprice = 100;
                    break;

                case 2:
                    tickettype = "Gold";
                    tprice = 200;
                    break;

                case 3:
                    tickettype = "platinium";
                    tprice = 300;
                    break;
            }
            totalcost = num * tprice;

        }
        public string Display()
        {
            return ($"Movie id is {mid} \n Movie Name is {mname}\n Price is {tprice} No of tickets {nooftickets}");
        }

    }
}
