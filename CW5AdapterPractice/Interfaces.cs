// Name: Zach Coomer
// Date: 2/9/2023
// Assignment: CW5: Adapter Practice!
// Class: 352
// Description: C# Code for Adapter, Interfaces File  

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW5AdapterPractice
{
    interface IToyBear
    {
        void hug();
    }

    interface IBear
    {
        void maul();
        void hibernate();
    }
}
