using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.DeleAndEventProg
{
    public class BankEventMM
    {
        static void Main(string[] args)
        {
            try
            {
                Bank bank = new Bank(1000);
                bank.insufficientBal += delegate () { Console.WriteLine("Balance is insuffient"); };
                bank.LowBalance += delegate () { Console.WriteLine("Balacnce is Low"); };
                bank.ZeroBalance += delegate () { Console.WriteLine("Balance is Zero"); };
                bank.DebitAmt(500);
                bank.CreditAmt(200);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message); 
            }
        }
    }
}
