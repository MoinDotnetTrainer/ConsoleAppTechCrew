using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTechCrew
{
    internal class ConstReadonlyClass1
    {
        int y;
        const int x = 3;
        readonly int x2;

        readonly dynamic x_ = 24;

        public ConstReadonlyClass1()
        {
            //  x = 45;
            const int z = 456567;
            Console.WriteLine(z);
            x2 = 654;

            // readonly int x12=34;
        }

        public void M1()
        {
            //  x = 123;
            const int z1 = 234545;
            Console.WriteLine(z1);
            // x2 = 456;
            Console.WriteLine(x2);

            // readonly int x122 = 34;
        }

        public void M2()
        {
            // x2 = 6;
            Console.WriteLine(x2);
            // readonly int x12 = 34;
        }


    }
}
