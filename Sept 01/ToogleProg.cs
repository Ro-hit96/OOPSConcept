using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.Sept_01
{
    public class ToogleProg
    {
        static void Main(string[] args)
        {
            string str = "INDIA is  country";
            char[] ch = str.ToCharArray();
            string str2 = "";

            for(int i = 0; i < ch.Length; i++)
            {
                if (ch[i]>='a' && ch[i] <= 'z')
                {
                    int a = (int)(ch[i]-32);
                    ch[i]= (char)a;
                }
                else if(ch[i] >= 'A' && ch[i] <= 'Z')
                {
                    int A= (int)(ch[i]+32);
                    ch[i]= (char)A;
                }
            }

            str=new string(ch);
            Console.WriteLine(str);

        }
    }
}
