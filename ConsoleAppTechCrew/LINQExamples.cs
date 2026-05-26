using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTechCrew
{

    class Info
    {
        public int ID { get; set; }
        public string Fname { get; set; }
        public string lname { get; set; }
        public int Age { get; set; }
        public string gender { get; set; }
    }
    internal class LINQExamples
    {
        public static void Basics()
        {
            /// BAsic Linq Synatx
            /// 
            int[] arr = { 55, 1, 2, 345, 50, 64, 65, 75, 12, 7, 12, 23, 24, 7, 12, 10, 20, 30, 10, 20, 30, 23, 24, 7686, 345, 50, 64, 65, 75, 7, 7686, 897, 980, 980, 8, 46, 57, 5, 68, 79, 87 };
            int[] arr1 = { 345, 50, 64, 123, 435, 346, 4567, 567, 58, 679, 87, 10, 20, 30, 10, 20, 30 };


            List<int> list = new List<int>() { 34, 56, 5, 657, 67, 68, 78, 78, 79, 89, 88, 0, 45, 65767 };
            object[] obj = { 23, 34.5, 345, 4654, 345.54, 4, true, false, "Hi", "test", 'A', 'B' };


            List<Info> infos = new List<Info>() {
            new Info{ ID=1,Fname="abc",lname="pqr",Age=34,gender="Male"},
            new Info{ ID=2,Fname="abc1",lname="pqr1",Age=23,gender="Female"},
            new Info{ ID=3,Fname="abc2",lname="pqr2",Age=45,gender="Male"},
            new Info{ ID=4,Fname="abc3",lname="pqr3",Age=23,gender="Female"},
            new Info{ ID=5,Fname="abc4",lname="pqr4",Age=33,gender="Male"}
            };


            // Getting data from arr using Linq SYnatx
            // Select id,name from tblname
            // 
            var result = from s in arr select s;  // linq SYntax ,, condtions
            var res1 = from s in arr where s > 50 select s;
            var res2 = from s in arr where s != 50 select s;


            var res3 = from s in infos where s.gender == "Male" select s;


            var res4 = infos.Where(x => x.gender == "Female").ToList();

            var res5 = from s in infos
                       where s.Age > 30
                       select new
                       {
                           Fname = s.Fname,
                           lname = s.lname
                       };


            // Query , Method syntax , Both
            foreach (var item in res5)
            {
                //  Console.WriteLine(item);
                //  Console.WriteLine($"Id is {item.ID} fname is {item.Fname} last name is {item.lname} age is {item.Age} Gender is {item.gender}");
                //  Console.WriteLine($"fname is {item.Fname} last name is {item.lname} ");
            }


            var res6 = (from s in arr select s).Distinct();
            var res7 = (from s in arr select s).DistinctBy(x => x > 50);
            foreach (var item in res7)
            {
                //Console.WriteLine(item);
            }



            var res8 = obj.OfType<bool>().ToList();
            foreach (var item in res8)
            {
                // Console.WriteLine(item);
            }

            var res9 = from s in arr.Union(arr1) select s;  // only unique
            var res10 = from s in arr.UnionBy(arr1, x => x == 10) select s;

            var res11 = from s in arr.Concat(arr1) select s;  //a ll


            var res12 = from s in arr.Intersect(arr1) select s;  // common

            var res13 = from s in arr.Except(arr1) select s;  // unique from left

            // only the unique from both
            foreach (var item in res13)
            {
                // Console.WriteLine(item);
            }

            var res14 = (from s in arr select s).Count();
            var res15 = (from s in arr select s).Max();
            var maxby = (from s in arr select s).MaxBy(x => x < 50);
            var maxby1 = (from s in arr select s).MaxBy(x => x == 50);

            var res16 = (from s in arr select s).Min();
            var res17 = (from s in arr select s).Sum();
            var res18 = (from s in arr select s).Average();

            var res19 = (from s in arr select s).Reverse();
           
            foreach (var item in res19)
            {
                 Console.WriteLine(item);
            }
        }
    }
}
