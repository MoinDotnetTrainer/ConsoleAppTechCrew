namespace ConsoleAppTechCrew
{
    internal class Program
    {
        static void Main(string[] args)  // entry point
        {
            System.Console.WriteLine("Hello, World!");

            // call those two class here 
            // Creating an object of those 

            //Demo obj = new Demo();
            //obj.Test();
            //obj.Test1();

            //Sample s = new Sample();
            //s.MyRecords();

            //Products p = new Products();
            //p.Myproducts();

            //  DataTypes dt = new DataTypes();
            //  dt.ArrayEx();

            //  ExampleOnClass obj = new ExampleOnClass();
            //obj.Add();
            //obj.Sub();
            //obj.Mul(234, 2);
            //obj.Test([45, 456, 6, 756, 7]);

            //  int result = obj.Div(12, 2);
            //Console.WriteLine(result);
            //  obj.Optnl(12);

            //(int x, string y)  = obj.UserDetails();
            //Console.WriteLine(x);
            //Console.WriteLine(y);

            // ExampleOnClass.M1();
            // obj.M2();


            // OverLoad obj = new OverLoad();
            //  obj.M1(12,43);


            //  StaticClass1.M1();


            //  ConstrExample obj = new ConstrExample("2"); // constr
            //  obj.M1();
            //  ConstrExample.M2();


            // ConstReadonlyClass1 obj = new ConstReadonlyClass1();
            // obj.M1();

            //  ParentClass.Add();
            // ParentClass.Sub();


            ///ChildClass.Mul();
            // ChildClass.Add();
            // ChildClass.Sub();
            //  ChildClass.Div();

            // ParentClass.x = 36;

            //   ConstrChain obj = new ConstrChain();

            //ChildConstrChain obj = new ChildConstrChain();


            HRDept hr = new HRDept();
            hr.Employees(); // 1 task


            TechEmployyee te = new TechEmployyee();
            te.Employees();  // another

            NoNtech non = new NoNtech();
            non.Employees(); // another task

        }
    }
}
