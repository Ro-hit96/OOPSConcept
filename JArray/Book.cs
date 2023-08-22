using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOPSConcept.JArray
{
    public class BookB2
    {
        public int bookid { get; set; }
        public string BName { get; set; }

        public string BAuthor { get; set; }

        public int BPrice { get; set; }
    }

    public class BookMM
    {


        static void Main(string[] args)
        {
            BookB2[] book = new BookB2[2]
            {
                new BookB2 { bookid = 1, BName = "ABC", BAuthor = "Sandy", BPrice = 2000 },
                new BookB2 { bookid = 2, BName = "CDE", BAuthor = "EFG", BPrice = 6700 },
        };
            foreach (BookB2 bk in book)
            { 
                Console.WriteLine($"id={bk.bookid} Name={bk.BName} Author={bk.BAuthor} Price{bk.BPrice}");
            }
        }
    }
 }

