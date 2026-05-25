using System;
using System.Xml;

namespace ConsoleAppTechCrew
{
    internal class Program
    {
        static void Main(string[] args)  // entry point
        {
            //   System.Console.WriteLine("Hello, World!");

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


            //HRDept hr = new HRDept();
            //hr.Employees(); // 1 task


            //TechEmployyee te = new TechEmployyee();
            //te.Employees();  // another

            //NoNtech non = new NoNtech();
            //non.Employees(); // another task

            //Orders o = new Orders();
            //o.Sales();
            //o.Profit();
            //o.Inventory();

            //Demo d = new Demo();
            //d.Test();
            //d.Test1();
            //d.Test2();
            //d.Test3();

            //  Exception.Div();

            //  RefOut obj = new RefOut();
            //obj.Calculation(12, 2, out int add, out int sub, out int mul, out int div);
            //Console.WriteLine(add);
            //Console.WriteLine(sub);
            //Console.WriteLine(mul);
            //Console.WriteLine(div);

            //obj.calci(23,3);

            //   obj.Exe();


            //try
            //{
            //    Prop p = new Prop();
            //    p.x_ = 134;  // paper 1 50
            //    p.y_ = 34;  // paper 2 50 = 100
            //    p.Add();
            //}
            //catch (System.Exception ex)
            //{
            //    Console.WriteLine(ex.Message); 
            //}


            //Index obj = new Index();
            //obj[0] = -23;
            //obj[1] = 18;
            //obj[2] = 23;
            //Console.WriteLine(obj[0]);
            //Console.WriteLine(obj[1]);
            //Console.WriteLine(obj[2]);

            //GenMethod obj = new GenMethod();
            //obj.M2(23,34);
            //obj.M3<int , string>(34,"hi");
            //obj.M3<string, bool>("hi",true);

            //GenClass<int, int> obj1 = new GenClass<int, int>();
            //obj1.M1(2,3);
            //obj1.M2("",true);


            // Collections obj = new Collections();
            //obj.StoreUsersData();


            Delegates_Example obj = new Delegates_Example();


            // we can invoke a method thrw delegates
            // signle cast delegates
            // FirstClass fs = new FirstClass(obj.Add);
            // fs.Invoke();
            //FirstClass fs1 = new FirstClass(obj.Sub);
            //fs1.Invoke();

            //SecondClass sc = new SecondClass(obj.Mul);
            //sc.Invoke(12, 2);
            //SecondClass sc1 = new SecondClass(obj.Div);
            //sc1.Invoke(12, 2);


            // multi cast 
            //FirstClass Multi1 = new FirstClass(obj.Add);
            //Multi1 += new FirstClass(obj.Sub);
            //Multi1.Invoke();

            //SecondClass multi12 = new SecondClass(obj.Mul);
            //multi12 += new SecondClass(obj.Div);
            //multi12 -= new SecondClass(obj.Div);
            //multi12.Invoke(12, 2);


            /* FirstClass firstClass = delegate ()
             {
                 Console.WriteLine(" am the first method ");
             };

             FirstClass fs1 = () =>
             {
                 Console.WriteLine(" ammomous methid");
             };
             fs1();
             firstClass();

             SecondClass sc = delegate (int x, int y)
             {
                 return x + y;
             };
             SecondClass sc1 = (int x, int y) =>
             {
                 return x + y;
             };


             int res = sc(12, 3);



         // pre define delegates in c#
         // action func , predicate
         // Void , int & bool

         // prop acts  table field
            */

            Delegates_Example ds = new Delegates_Example();
            ds.greet("Hi");
            int res = ds.multiply(12, 2);
          bool res1=  ds.isPositive(23);
            Console.WriteLine(res);
            Console.WriteLine(res1);
        }
    }
}
