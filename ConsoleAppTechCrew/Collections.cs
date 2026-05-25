using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTechCrew
{
    class Users
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }


    internal class Collections
    {

        public void StoreUsersData()
        {
            List<Users> users = new List<Users>();
            users.Add(new Users { ID = 1, Name = "Raj", Age = 34 });
            users.Add(new Users { ID = 2, Name = "Raj1", Age = 32 });
            users.Add(new Users { ID = 3, Name = "Ra2j", Age = 43 });
            users.Add(new Users { ID = 4, Name = "Raj3", Age = 12 });
            users.Add(new Users { ID = 5, Name = "Raj4", Age = 3 });

            foreach (var item in users)
            {
                Console.WriteLine($"Id  is {item.ID} name is {item.Name} and Age is {item.Age}");
            }
        }

        // dyanmic array lenth , no lenth
        // collection of Elements , homoegenous
        // insert,delete sort on Arrys
        // DSA , collecion 

        public void List()
        {
            // Classes --> Collections 
            // Class --> gen or Non Gen
            // 1. List 
            // Storing Insert delting , view Easily Gen coll
            List<int> list = new List<int>() { 45, 56, 6, 76, 7, 87, 87, 89, 89, 80, 3, 53, 645, 64, 575, 67, 5 };
            List<string> list2 = new List<string>() { "xyz", "abx", "pqr", "test" };

            List<int> list3 = new List<int>();
            list3.Add(34);
            list3.Add(456);
            list3.Add(56);
            list3.Add(3234);
            list3.Add(235);
            list3.Add(5);
            list3.Add(7);
            list3.Add(34);
            list3.Add(456);
            list3.Add(56);
            list3.Add(3234);
            list3.Add(235);
            list3.Add(5);
            list3.Add(7);
            list3.Add(879);
            list3.Add(23);
            list3.Add(53);
            list3.Remove(235);
            list3.RemoveAt(0);  // index
            list3.Insert(0, 123);
            list3.Sort();
            //int[] arr = { 35,46};

            //for (int i = 0; i < arr.Length; i++)
            //{

            //}
            //for (int i = 0; i < list3.Length; i++)
            //{

            //}
            foreach (int item in list3)
            {
                Console.WriteLine(item);
            }

        }

        public void hashset()
        {
            // Classes --> Collections 
            // Class --> gen or Non Gen
            // 1. List 
            // Storing Insert delting , view Easily Gen coll
            List<int> list = new List<int>() { 45, 56, 6, 76, 7, 87, 87, 89, 89, 80, 3, 53, 645, 64, 575, 67, 5 };
            List<string> list2 = new List<string>() { "xyz", "abx", "pqr", "test" };

            HashSet<int> list3 = new HashSet<int>();
            list3.Add(34);
            list3.Add(456);
            list3.Add(56);
            list3.Add(34);
            list3.Add(456);
            list3.Add(56);
            list3.Add(3234);
            list3.Add(235);
            list3.Add(5);
            list3.Add(7);
            list3.Add(34);
            list3.Add(456);
            list3.Add(56);
            list3.Add(3234);
            list3.Add(235);
            list3.Add(5);
            list3.Add(7);
            list3.Add(879);
            list3.Add(23);
            list3.Add(53);
            list3.Remove(235);

            // no duplicates are allowed

            //int[] arr = { 35,46};

            //for (int i = 0; i < arr.Length; i++)
            //{

            //}
            //for (int i = 0; i < list3.Length; i++)
            //{

            //}
            foreach (int item in list3)
            {
                Console.WriteLine(item);
            }

        }
        public void Sorted()
        {
            // Classes --> Collections 
            // Class --> gen or Non Gen
            // 1. List 
            // Storing Insert delting , view Easily Gen coll
            List<int> list = new List<int>() { 45, 56, 6, 76, 7, 87, 87, 89, 89, 80, 3, 53, 645, 64, 575, 67, 5 };
            List<string> list2 = new List<string>() { "xyz", "abx", "pqr", "test" };

            SortedSet<int> list3 = new SortedSet<int>();
            list3.Add(34);
            list3.Add(456);
            list3.Add(56);
            list3.Add(34);
            list3.Add(456);
            list3.Add(56);
            list3.Add(3234);
            list3.Add(235);
            list3.Add(5);
            list3.Add(7);
            list3.Add(34);
            list3.Add(456);
            list3.Add(56);
            list3.Add(3234);
            list3.Add(235);
            list3.Add(5);
            list3.Add(7);
            list3.Add(879);
            list3.Add(23);
            list3.Add(53);
            list3.Remove(235);

            // no duplicates are allowed

            //int[] arr = { 35,46};

            //for (int i = 0; i < arr.Length; i++)
            //{

            //}
            //for (int i = 0; i < list3.Length; i++)
            //{

            //}
            foreach (int item in list3)
            {
                Console.WriteLine(item);
            }

        }

        public void Stack()
        {

            Stack<int> stack = new Stack<int>();

            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            stack.Pop();

            // Console.WriteLine(stack.Pop()); // 30

            foreach (int item in stack)
            {
                Console.WriteLine(item);
            }
        }
        public void Queue()
        {
            Queue queue = new Queue();

            queue.Enqueue("A");
            queue.Enqueue("B");
            queue.Enqueue(34);

            Console.WriteLine(queue.Dequeue());

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
        }

        public void Arraylist()
        {

            ArrayList al = new ArrayList();
            al.Add(34);
            al.Add("hi");
            al.Add(true);
            al.Add(34.45);
            al.Insert(0, 100);
            al.Remove(34);
            al.RemoveAt(0);
            foreach (var item in al)
            {
                Console.WriteLine(item);
            }
        }
    }
}
