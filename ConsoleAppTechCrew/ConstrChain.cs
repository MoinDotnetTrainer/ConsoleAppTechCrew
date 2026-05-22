using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTechCrew
{
    class ConstrChain
    {
        public ConstrChain():this("test") {
            Console.WriteLine("o pm constr");
        }

        public ConstrChain(string name):this(123,3) {
            Console.WriteLine(" 1 str const");
        }

        public ConstrChain(int x, int y) {
            Console.WriteLine("2 int const");
        }
    }

    class ChildConstrChain : ConstrChain {
        public ChildConstrChain():base("test") {
            Console.WriteLine("child default");
        }
    }
}
