using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTechCrew
{
    class Prop
    {
        //  int x, y, z;
        // security , misuse of data
        // y , public 

        // properties

        private int x;  // variable value type 
        public int x_
        {
            get { return x; }
            set
            {
                if (value > 50 || value < 0)
                {
                    throw new ArgumentException("Value is not in range");
                }
                else
                {
                    x = value;
                }
            }
        }

        private int y;

        public int y_
        {
            get { return y; }
            set
            {
                if (value > 50 || value < 0)
                {
                    throw new ArgumentException("Value is not in range");
                }
                else
                {
                    y = value;
                }
            }
        }


        public void Add()
        {
            int z = x + y;
            Console.WriteLine(z);
        }
    }

    class Index
    {
        private int[] Age = new int[3];

        public int this[int index]
        {
            set
            {
                if (index >= 0 && index < Age.Length)
                {
                    if (value > 0)
                    {
                        Age[index] = value;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Age");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Index");
                }
            }
            get
            {
                return Age[index];
            }



        }
    }
}