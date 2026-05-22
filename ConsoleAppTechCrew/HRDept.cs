using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTechCrew
{
    class HRDept
    {
        public virtual void Employees()  // option to overide in a child
        {
            Console.WriteLine(" List Of HR Employees");
        }
    }

    class TechEmployyee : HRDept
    {
        public override void Employees()
        {
            Console.WriteLine("100 tech Emp");
        }
    }

    class NoNtech : HRDept
    {
        public override void Employees()
        {
            Console.WriteLine("1000 Non tech Emp");
        }
    }

    class Visitors : HRDept {
        public void NoOfVisitors() {
            Console.WriteLine("100 per day Visitors");
        }
    }
}
