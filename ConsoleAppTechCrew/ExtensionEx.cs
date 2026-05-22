using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTechCrew
{
    static class ExtensionEx
    {
        public static void Test2(this Demo obj) {
            Console.WriteLine("test 2 from anotehr class");
        }

        public static void Test3(this Demo obj) {
            Console.WriteLine("test 3 from anotehr class");
        }
    }
}
