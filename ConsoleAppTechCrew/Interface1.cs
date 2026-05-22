using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTechCrew
{


    interface Interface1
    {
        void add();  // like for Overriding
    }

    interface Interface2
    {
        void Sub();
    }

    abstract class Class3
    {
        public abstract void Mul();
    }

    abstract class Class4
    {
        public abstract void Div();
    }

    class ImplementInterfaces : Class3, Interface1, Interface2
    {
        public void add()
        {
            Console.WriteLine("Add here");
        }

        public void Sub()
        {
            Console.WriteLine("Add here");
        }

        public override void Mul()
        {
           
        }
    }
}
