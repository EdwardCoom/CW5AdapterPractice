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
    // Implements the IToybear interface
    class TeddyBear : IToyBear
    {
        public void hug()
        {
            Console.WriteLine("This bear gives a soft hug.");
        }
    }

    // Implements the IBear interface
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

    // The adapter that implements the IToyBear interface and adapts the Bear interface
    class BearAdapter : IToyBear
    {
        IBear adaptedBear;
        // member variable, adaptee

        BearAdapter(IBear b)
        {
            adaptedBear = b;
        }
        // Parameterized constructor

        public void hug()
        {
            adaptedBear.maul();
        }
    }
}
