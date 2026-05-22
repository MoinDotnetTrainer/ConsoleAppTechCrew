using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTechCrew
{
    internal class OverLoad
    {
        public  void M1() { // method ooverload
            Console.WriteLine("First task");
        }
        public static void M1(int x)  // int with 1 argument
        {
            Console.WriteLine("second task");
        }
        public static void M1(int x , int y)
        {
            Console.WriteLine("third task");
        }
        public static void M1(int x , string y)
        {
            Console.WriteLine("fourth task");
        }
        public static void M1(string x, int y)
        {
            Console.WriteLine("fifth task");
        }

        public static void M1(string x, string y)
        {
            Console.WriteLine("sixth task");
        }
    }
}
