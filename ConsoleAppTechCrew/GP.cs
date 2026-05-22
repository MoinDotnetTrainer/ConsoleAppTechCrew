using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTechCrew
{
    class GP
    {
        public int x; public int y; public int z;
    }

    class P : GP
    {
        public int z1;
        public void Test()
        {
            x = 34;
        }
    }

    class C : P
    {
        public void Testing()
        {
            z1 = 3546;
            x = 345;
        }
    }

}
