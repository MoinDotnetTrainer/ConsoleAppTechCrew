using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTechCrew
{
    class ParentClass
    {
        public static int x, y, z;
        public static void Add()
        {
            x = 45;
            y = 45;
            z = x + y;
            Console.WriteLine("Add is:" + z);
        }
        public static void Sub()
        {
            x = 45;
            y = 45;
            z = x - y;
            Console.WriteLine("Sub is:" + z);
        }
    }

    class ChildClass : ParentClass
    {

        public static void Mul()
        {
            Add();
            //Sub();
            x = 45;
            y = 45;
            z = x * y;
            Console.WriteLine("mul is:" + z);
        }
        public static void Div()
        {
            x = 45;
            y = 45;
            z = x / y;
            Console.WriteLine("Div is:" + z);
        }
    }
    class ChildClass1 : ParentClass
    {

        public static void Calci()
        {
            //Add();
            //Sub();
            x = 45;
            y = 45;
            z = x * y;
            Console.WriteLine("mul is:" + z);
        }
        public static void OPs()
        {
            x = 45;
            y = 45;
            z = x / y;
            Console.WriteLine("Div is:" + z);
        }
    }
}
