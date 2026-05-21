using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTechCrew
{
    internal class DataTypes
    {
        public void DtExample()
        {
            // interger 0-9
            // 4 byte1 short2 int4 long8
            // 1byte = 8 bits = 0-255
            // Byte --> byte sbyte
            // short  --> short ushort


            // float 0.00

            // float double decimal
            // bool .. t/F
            // string  group of char
            // date time 
            // other categiroes


            // 1 byte 0-255 
            byte b = 255;  // unsigned + values

            //-128 to 127
            sbyte sb = 127;  // signed +- values

            float f = 23.45f;
            double d = 245.35;
            decimal dm = 345.45m;

            char c = 'B';

            bool status = false;

            string str = "kjhkjhkiuewyriwufyeriy875685757567";

            // var dynamic & object


            // compile time  -> during the program 
            var v = 234;
            v = 56;
            v = 56;
            v = 234;
            v = 435;
            //   v = true;
            var v1 = 2454.67;
            //  v1 = true;
            var v2 = true;
            // v2 = 345;
            var v3 = "Hi hello";


            // runtime
            dynamic d1 = 45;// int
            d1 = true;  // bool
            d1 = "test"; // string
            dynamic d2 = 45.56;
            dynamic d3 = true;
            dynamic d4 = "test";
            dynamic d5 = 36;
            dynamic res = d1 + d5;

            // value type
            // ref type

            object o1 = 234;
            o1 = true;
            o1 = 234.35;
            object o2 = 234.56;
            object o3 = true;
            object o4 = "test";
            object o5 = 56;
            object result = (int)o1 + (int)o5;

            // value ref
            //1+2
            //"123"+"456"

            //value type & ref type

            int? x = null;
            // mark x as nullable
            string name = null;


            // boxing & unboxing


            int myres = 3;
            object o = myres;  // boxing
            int rs_ = (int)o;  // unboxing

            // implict & explict casting


            // implict 
            byte b_ = 123;  // lower
            int x_ = b_;  // higher

            //explcit 

            byte bb_ = (byte)x_;  // explict 



        }

        public void ReadLine()
        {
            Console.WriteLine("Enter Ur name");
            string name = Console.ReadLine();  // no error
            Console.WriteLine($"Name is {name}");  // string interpolation

            Console.WriteLine("Enter ur age");
            int age = Convert.ToInt32(Console.ReadLine());  // error here


            // 4 byte 2 byte
            // 0-255

            // readline return o/p in string format
            Console.WriteLine($" Age is {age}");
        }

        public void Parsing()
        {
            Console.WriteLine("Enter Ur name");
            string name = Console.ReadLine();  // no error
            Console.WriteLine($"Name is {name}");  // string interpolation

            Console.WriteLine("Enter ur age");
            short age = short.Parse(Console.ReadLine());  // error here


            // 4 byte 2 byte
            // 0-255

            // readline return o/p in string format
            Console.WriteLine($" Age is {age}");
        }

        public void Diff()
        {
            string str = null;  // string value with number
                                //  Console.WriteLine(str.GetType());
                                //  int x = Convert.ToInt32(str);  // 0
            int x = int.Parse(str);  // error
            Console.WriteLine(x);  // 123
                                   //   Console.WriteLine(x.GetType());
        }
    }
}
