using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTechCrew
{
    internal class GenMethod
    {
        public void M1() { }

        public void M2(int x, int y)
        {  // data  type as an argument
            Console.WriteLine(x);
            Console.WriteLine(y);
        }

        // type as an argument , generic

        public void M3<t1, t2>(t1 x, t2 y)
        { // types 
            Console.WriteLine(x);
            Console.WriteLine(y);
        }
    }

    class GenClass<t1, t2>
    {
        public void M1(t1 x, t2 y) { Console.WriteLine(x); Console.WriteLine(y); }
        public void M2(t1 x, t2 y) { Console.WriteLine(x); Console.WriteLine(y); }
        public void M3(t1 x, t2 y) { Console.WriteLine(x); Console.WriteLine(y); }
        public void M4(t1 x, t2 y) { Console.WriteLine(x); Console.WriteLine(y); }
        public void M5(t1 x, t2 y) { Console.WriteLine(x); Console.WriteLine(y); }
    }
}
