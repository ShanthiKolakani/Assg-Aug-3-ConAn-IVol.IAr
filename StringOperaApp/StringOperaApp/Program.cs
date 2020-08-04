using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringOperaApp
{
    class Program
    {
        static void Main()
        {
            
            Console.WriteLine("Enter First String");
        string  g= Console.ReadLine();
            Console.WriteLine("Enter Second String");
        string h= Console.ReadLine();
            string[] s = {"1.Conscatenate Strings.",
                           "2.Lengths of Two String.",
                             "3.SubString.",
                               "4.Replace.",
                                  "5.Upper case.",
                                     "6.Lower case.",
                                        "7.Trim.",
                                           "8.Split."};
            int i = 0;
            for( i=0; i<s.Length;i++)
            {
                Console.WriteLine(s[i]);
            }

            string str =  g + h ;
            Console.WriteLine(str);
            Console.WriteLine(str.Length);
            Console.WriteLine(h);
            string str1 = str.Replace(" ", "bliss");
            Console.WriteLine(str1);  
            string str2 = str.ToUpper();
            Console.WriteLine(str2);
            string str3 = str.ToLower();
            Console.WriteLine(str3);
           
           // string str4 = str.Split(g);
            //Console.WriteLine(str4);
            string str5 = "**hello**";
            char[] t = { '*' };
            string str6= str5.Trim(t);
            Console.WriteLine(str6);
            Console.Read();
            
      //  Convert.ToInt32(Console.ReadLine(str.Length));     

            Console.WriteLine("Make the choice again Enter 9 to exit");
            Console.Read();
        }
    }
}
