using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.Inheritance
{
     public class PersonAndPatient
     {
         protected string name, address;
         protected double adharno;

         public PersonAndPatient(string name, double adharno,string address)
         {
             this.name = name;
             this.address = address;
             this.adharno = adharno;
         }
         public virtual string Display()
         {
             return $"{name}{adharno}{address}";
         }
      }
     public class Patient : PersonAndPatient
     {
         private string bloodgroup, gender;
         private int fees;
         public Patient(string bloodgroup, string gender, int fees, string name, double adharno, string address) :base (name, adharno, address)
         {
             this.bloodgroup = bloodgroup;
             this.gender = gender;
             this.fees = fees;
         }
         public override string Display()
         {
             return $"{name}\n{address}\n{adharno}\n{bloodgroup}\n{gender}\n{fees}";
         }
     }
}

