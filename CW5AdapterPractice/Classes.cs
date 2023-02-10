// Name: Zach Coomer
// Date: 2/9/2023
// Assignment: CW5: Adapter Practice!
// Class: 352
// Description: C# Code for Adapter, Classes File 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW5AdapterPractice
{
    class TeddyBear : IToyBear
    {
        public void hug()
        {
            Console.WriteLine("This bear gives a soft hug.");
        }
    }

    class Grizzly : IBear
    {
        public void maul()
        {
            Console.WriteLine("This bear ferociously attacks!");
        }

        public void hibernate()
        {
            Console.WriteLine("This bear is out till March.");
        }
    }

    class BearAdapter
    {
        IBear adaptedBear;

        BearAdapter(IBear b)
        {
            adaptedBear = b;
        }

        public void hug()
        {
            adaptedBear.maul();
        }
    }
}
