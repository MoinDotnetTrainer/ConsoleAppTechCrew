using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTechCrew
{
    class Emp
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
        public string Dept { get; set; }
        public decimal Salary { get; set; }
        public bool Status { get; set; }
    }

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

            IEnumerable<int> QuerySyntax = from s in arr
                                           where s > 5
                                           select s;

            foreach (var item in QuerySyntax)
            {
                Console.WriteLine(item + "Ienum ");
            }

            IQueryable<int> MethodSyntax = arr.AsQueryable()
                                .Where(x => x > 10);

            foreach (var item in MethodSyntax)
            {
                Console.WriteLine(item+"I Quer");
            }
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
                // Console.WriteLine(item);
            }

            int[] source = { 1, 2, 3, 4, 5, 6, 24, 34, 55, 6546, 54, 7, 76, 867, 86, 88, 978 };

            // all ANy contains --> bool value based on a cond

            var res20 = (from s in source select s).All(x => x > 20);
            var res21 = (from s in source select s).Any(x => x > 20);

            // T F based on a cond 
            // Console.WriteLine(res21);

            List<Emp> Empobj = new List<Emp>()
{
    new Emp    {
        ID = 1,
        Name = "Moin",
        Email = "moin@gmail.com",
        Password = "Moin@123",
        Gender = "Male",
        Dept = "IT",
        Salary = 45000,
        Status=true
    },

    new Emp    {
        ID = 2,
        Name = "Sara",
        Email = "sara@gmail.com",
        Password = "Sara@123",
        Gender = "Female",
        Dept = "HR",
        Salary = 38000,
        Status=true
    },

    new Emp    {
        ID = 3,
        Name = "Rahul",
        Email = "rahul@gmail.com",
        Password = "Rahul@123",
        Gender = "Male",
        Dept = "Finance",
        Salary = 52000, Status=true
    },

    new Emp    {
        ID = 4,
        Name = "Ayesha",
        Email = "ayesha@gmail.com",
        Password = "Ayesha@123",
        Gender = "Female",
        Dept = "Admin",
        Salary = 41000,Status=true
    },

    new Emp    {
        ID = 5,
        Name = "Kiran",
        Email = "kiran@gmail.com",
        Password = "Kiran@123",
        Gender = "Male",
        Dept = "Testing",
        Salary = 47000,Status=false
    }
};


            var Login = (from s in Empobj select s).Any(x => x.Email == "kiran@gmail.com" && x.Password == "Kiran@123");
            var Status = (from s in Empobj select s).All(x => x.Status == true);
            var contains = source.Contains(1);
            //  Console.WriteLine(contains);
            var contains1 = Empobj.Where(x => x.Name.Contains("Kiran")).ToList();
            foreach (var item in contains1)
            {
                //    Console.WriteLine(item.Name);
            }

            int[] Records = { 11, 12, 13, 1, 234, 7, 67, 5, 678, 68, 69, 789, 79, 10 };

            /* 
             var ElemenetAT = (from s in Records select s).ElementAt(10);
             var ElemenetATdef = (from s in Records select s).ElementAtOrDefault(100);
             var First = (from s in Records select s).First(x => x > 10);
             var Firstdef = (from s in Records select s).FirstOrDefault(x => x > 100000);
             var last = (from s in Records select s).Last(x => x < 10);
             var lastdef = (from s in Records select s).LastOrDefault();
            */

            var single = (from s in Records select s).Single(x => x == 10);
            // Console.WriteLine(single);
            var take = (from s in Records select s).Take(5);
            var skip = (from s in Records select s).Skip(5);

            var takewhile = (from s in Records select s).TakeWhile(x => x > 10);
            var takelast = (from s in Records select s).TakeLast(5);

            var skipwhile = (from s in Records select s).SkipWhile(x => x > 10);
            var skiplast = (from s in Records select s).SkipLast(5);
            foreach (var item in skipwhile)
            {
                //  Console.WriteLine(item);
            }


            List<Info> objdata = new List<Info>() {
            new Info{ ID=1,Fname="abc",lname="pqr",Age=34,gender="Male"},
            new Info{ ID=2,Fname="abc1",lname="pqr1",Age=23,gender="Female"},
            new Info{ ID=3,Fname="abc2",lname="pqr2",Age=45,gender="Male"},
            new Info{ ID=4,Fname="abc3",lname="pqr3",Age=23,gender="Female"},
            new Info{ ID=5,Fname="abc4",lname="pqr4",Age=33,gender="Male"}
            };


            var groupby1 = (from s in objdata group s by s.Age);//key
            var groupby = (from s in objdata group s by s.gender);//key


            var lookup = objdata.ToLookup(x => x.gender);

            objdata.Add(new Info { ID = 6, Fname = "test", lname = "testing", Age = 33, gender = "Male" });


            Console.WriteLine("group by ");
            foreach (var item in groupby)
            {
                //Console.WriteLine(item.Key);
                foreach (var data in item)
                {
                   // Console.WriteLine($"Id is {data.ID} fname is {data.Fname} last name is {data.lname} age is {data.Age} Gender is {data.gender}");
                }
            }
            Console.WriteLine("loop up ex below");

            foreach (var item in lookup)
            {
                //Console.WriteLine(item.Key);
                foreach (var data in item)
                {
                 //   Console.WriteLine($"Id is {data.ID} fname is {data.Fname} last name is {data.lname} age is {data.Age} Gender is {data.gender}");
                }
            }

            var Lazy = from s in objdata where s.Age > 30 select s; //3 
            var immediate = (from s in objdata where s.Age > 30 select s).Count();// 3

            objdata.Add(new Info { ID = 6, Fname = "abc5", lname = "pqr5", Age = 33, gender = "Male" });

            // sort the elements asc desc

            var Orderby = from s in objdata orderby s.Age select s;
            var Orderbydesc = from s in objdata orderby s.Age descending select s;

            // sort from second field onwards thenby

            var thenby = objdata.OrderBy(x => x.Fname)
                                 .ThenBy(X => X.lname).ThenByDescending(x => x.Age);




            foreach (var item in Lazy) // 4
            {
                //   Console.WriteLine($"Id is {item.ID} fname is {item.Fname} last name is {item.lname} age is {item.Age} Gender is {item.gender}");
            }
            //  Console.WriteLine(immediate);  //4
        }
    }
}
