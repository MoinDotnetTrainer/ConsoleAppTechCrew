using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTechCrew
{
    internal class ParentDish
    {
        public virtual void NoNVegDish() {
            Console.WriteLine(" Non veg dish");
        }
    }

    class C1 : ParentDish {
        public override void NoNVegDish()
        {
            Console.WriteLine(" I dont Like");
        }
    }

    class C2 : ParentDish
    {
        public override void NoNVegDish()
        {
            Console.WriteLine(" I Like");
        }
    }
}
