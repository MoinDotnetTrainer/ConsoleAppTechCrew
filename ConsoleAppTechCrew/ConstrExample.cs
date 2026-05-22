using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTechCrew
{
    class ConstrExample
    {
        // Constr is also Method ,Sttaic & non Static

        public  ConstrExample() { // invoked auto on object creation
            Console.WriteLine("const task");
        }

        public ConstrExample(int x)
        { // invoked auto on object creation
            Console.WriteLine("1 const task");
        }

        public ConstrExample(string x)
        { // invoked auto on object creation
            Console.WriteLine("2 const task");
        }

        public void M1() {  // object
            Console.WriteLine("m1 task");
        }

        public static void M2() {  // class name
            Console.WriteLine("m2 task");
        }
    }
}
