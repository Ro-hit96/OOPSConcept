using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace OOPSConcept.Collection
{
    public class HashTable1
    {
        static void Main(string[] args)
        {
            Hashtable ht=new Hashtable();
            ht.Add("Docx", "Word File");
            ht.Add("xlsx", "Excel File");
            ht.Add("CS", "Source Code");
            ht.Add("html", "WebPage");

            ht.Remove("Docx");// based on key data will be removed from the hashtable

            foreach (DictionaryEntry item in ht)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

        }


    }
}

