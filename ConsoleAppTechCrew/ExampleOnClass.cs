using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTechCrew
{
    class ExampleOnClass
    {
        //data member & memver function

        int x, y, z;
        public void Add()
        {
            x = 35;
            y = 45;
            z = x + y;
            Console.WriteLine($"Add is {z}");
        }
        public void Sub()
        {
            x = 35;
            y = 45;
            z = x - y;
            Console.WriteLine($"Sub is {z}");
        }
        public void Mul(int x, int y)
        {
            z = x * y;
            Console.WriteLine($"Mul is {z}");
        }

        public void Test(int[] x)
        {
            foreach (var item in x)
            {
                Console.WriteLine(item);
            }
        }

        public void Test1(object x)
        {

        }

        public int Div(int x, int y)
        {
            int z = x / y;
            Console.WriteLine($"Div is {z}");  // i can see here
            return z;
        }

        public string str()
        {
            return "Hi";
        }

        public float f1()
        {
            return 13.34f;
        }

        public void Mytest(int x, int y)
        {
            Console.WriteLine("x:" + x);
            Console.WriteLine("y:" + y);
        }

        public void Optnl(int x, params int[] y)
        {
            Console.WriteLine("x:" + x);
            Console.WriteLine("y:" + y[0]);
        }

        public (int, string) UserDetails()
        {
            // multiple values
            return (12, "Test");
        }

        public static void M1()  // static method // one single shared accross
        {
            Console.WriteLine("M1 Method");
        }
        public void M2()  // Non static method
        {
            Console.WriteLine("M2 Method");
        }
    }
}
