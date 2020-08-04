using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAnimal
{
    class Program
    {
        static void Main()
        {
            string[] MyArray = { "Zebra", "Ant", "Owl", "Lion" };
            int i = 0;
            string[] animals = { "Zebra", "Kiwi", "Amazona Parrot", "Tiger" };
            string[] places = { "Africa", "New Zealand", "Jamaica", "India" };
           
            Array.Sort(animals);
            foreach (string w in animals)
                Console.WriteLine(w);
            //Console.WriteLine("\n");

            Array.Sort(places);
            foreach (string x in places)
                Console.WriteLine(x);

            for ( i=0; i<MyArray.Length; i++)
            {
                Console.WriteLine(MyArray[i]);
            }

            foreach (string n in MyArray)
                Console.WriteLine(n);
            int s = 0;
            do
            {
                Console.WriteLine(MyArray[s]);
                s++;
            } while (s < MyArray.Length);

            int v = 0;
            while(v < MyArray.Length)
            {
                Console.WriteLine( MyArray[v]);
                v++;
            }

            Console.Read();

        }
    }
}
