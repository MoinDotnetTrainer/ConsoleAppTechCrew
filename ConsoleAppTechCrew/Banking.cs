using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTechCrew
{
    abstract class Banking
    {
        // hdfc
        // abstract Method
        // method with a sign not a implementtaion , with abstract keyword

        // withdraw , deposite 

        public abstract void Withdraw(); // all banks withdraw getting amount
        public abstract void Deposite();


    }

    class HDFC : Banking {
        public override void Withdraw() { } // all banks withdraw getting amount
        public override void Deposite() { }
    }

    abstract class Vehicle
    {
        //pulsar vs vehilce
        // break , accelerate , cluctch

        public abstract void Break();
        public abstract void Accelerate();

        public void KickStart() { }
    }

    class KTM : Vehicle {
        public override void Break() { }

        public override void Accelerate() { }
    }


}
