using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTechCrew
{
    internal class MultiThread
    {
        public void M1() {
            for (int i = 0; i < 10; i++)
            {
                if (i==5)
                {
                    Thread.Sleep(3000);
                }
                Console.WriteLine("M1:"+i);
            }
        }

        public void M2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("M2:" + i);
            }
        }
    }
}
