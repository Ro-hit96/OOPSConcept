using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept
{
    public class Bank
    {
        private int accno;
        private string name;
        private double accbalance;
        //assign value to the data member
        public Bank(int accno,string name,double accbalance)
        {
            this.accno = accno;
            this.name = name;
            this.accbalance = accbalance;
        }
        public void Credit(double creditamt)
        {
            accbalance += creditamt;
            //+=is called short hand operator-->or
            //accbalance=accbalance+creditamt;
        }
        public string Debit(double debitamt)
        {
            string msg = "";
            if (debitamt <= accbalance)
            {
                accbalance = accbalance - debitamt;
                msg = "Done Transaction";
            }
            else
            {
                {
                    msg = "insufficient balance";
                }

            }
            return msg;
        }
        public string Print()
        {
             return $"Acc no {accno}, Name= {name}, Balance= {accbalance}";
        }

    }
}
