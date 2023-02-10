// Name: Zach Coomer
// Date: 2/9/2023
// Assignment: CW5: Adapter Practice!
// Class: 352
// Description: C# Code for Adapter, Main program implementation file 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW5AdapterPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating an IBear instance holding a Grizzly named john.\n");
            IBear john = new Grizzly();
            // IBear instance holding a Grizzly

            Console.WriteLine("Creating an IToyBear instance holding a TeddyBear named chad.\n");
            IToyBear chad = new TeddyBear();
            // IToyBear instance holding a TeddyBear

            Console.WriteLine("Creating an IToyBear instance holding a BearAdapter named kirby with an argument of john.\n");
            IToyBear kirby = new BearAdapter(john);
            // IToyBear instance holding a BearAdapter, with the Grizzly as the constructor argument

            Console.WriteLine("john maul() function:");
            john.maul();
            Console.WriteLine("\njohn hibernate() function:");
            john.hibernate();
            // IBear Functions with Grizzly

            Console.WriteLine("\nchad hug() function:");
            chad.hug();
            // IToyBear Functions with TeddyBear

            Console.WriteLine("\nkirby hug() function:");
            kirby.hug();
            // IToyBear Functions with BearAdapter

            Console.ReadKey();




        }
    }
}
