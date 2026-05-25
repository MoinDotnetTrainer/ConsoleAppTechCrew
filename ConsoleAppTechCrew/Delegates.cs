using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public delegate void FirstClass();
public delegate int SecondClass(int x, int y);

namespace ConsoleAppTechCrew
{
    class Delegates_Example
    {
        public Action<string> greet = delegate (string name)
        {
            Console.WriteLine($"Hello, {name}!");
        };

        public Func<int, int, int> multiply = delegate (int a, int b)
        {
            return a * b;
        };
        public Predicate<int> isPositive = delegate (int number)
        {
            return number > 0;
        };



        public void M1()
        {
            Console.WriteLine("Test task on M1");
        }
        public int M2(int x, int y)
        {
            return x + y;
        }
        public void Add()
        {
            int x = 45, y = 45, z;
            z = x + y;
            Console.WriteLine("Add is:" + z);
        }
        public void Sub()
        {
            int x = 45, y = 45, z;
            z = x - y;
            Console.WriteLine("Sub is:" + z);
        }

        public int Mul(int x, int y)
        {
            int z;
            z = x * y;
            Console.WriteLine("Mul is:" + z);
            return z;
        }

        public int Div(int x, int y)
        {
            int z;
            z = x / y;
            Console.WriteLine("Div is:" + z);
            return z;
        }
    }
}
