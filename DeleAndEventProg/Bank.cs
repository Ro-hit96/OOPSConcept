using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.DeleAndEventProg
{
    public delegate void MyBank();
    public class Bank
    {
        private double balance;
        public event MyBank insufficientBal;
        public event MyBank LowBalance;
        public event MyBank ZeroBalance;
        
        public Bank(double balance)
        {
            this.balance = balance;
         
        }

        public void CreditAmt(double creditamt)
        {
            balance = balance + creditamt;
           
            
        }
        public void DebitAmt(double debitamt)
        {
            balance = balance - debitamt;
            if (balance < debitamt)
            {
                insufficientBal();
            }
            else if(balance > debitamt)
            {
                LowBalance();
            }
            else
            {
                ZeroBalance();
            }
            
        }
    }
}
