using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTechCrew
{
    internal class RefOut
    {
        //out keywords is used return multiple values

        public void calci(int x, int y)
        {
            int add = x + y;
            int sub = x - y;
            int mul = x * y;
            int div = x / y;
            Console.WriteLine(add);
        }

        public void Calculation(int x, int y, out int add, out int sub, out int mul, out int div)
        {
            add = x + y;
            sub = x - y;
            mul = x * y;
            div = x / y;
        }

        public void Call(ref int x)  // x= 10 , what is x address , y
        {
            Console.WriteLine("before:" + x);  // 10
            x = x + 10;
            Console.WriteLine("After :" + x);  // 20
        }

        public void Exe()
        {
            int y = 10;
            Console.WriteLine("y before :" + y);  // 10 *&
            Call(ref y);  // value has been passed
            Console.WriteLine("y after :" + y);  // y = 20
        }

    }
}
