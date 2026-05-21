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

            DataTypes dt = new DataTypes();
            dt.Diff();
        }
    }
}
