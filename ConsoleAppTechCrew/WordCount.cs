using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTechCrew
{
    class WordCount
    {

        public int Call(string Filename)
        {

            int len = 0;
            using (StreamReader reader = new StreamReader(Filename))
            {
                string Words = reader.ReadToEnd();  // contnt ina file , read
                len = Words.Length;
                Task.Delay(5000).Wait();
            }

            return len;
        }

        public void Exe()
        {
            string Filename = "C:\\Users\\m.a.khaja.moinuddin\\OneDrive - Accenture\\Desktop\\Myfile.txt";

            int result = Call(Filename);
            Console.WriteLine("Task1");
            Console.WriteLine("Task2");
            Console.WriteLine("Task3");
            Console.WriteLine("No of Words:" + result); // 5 secods
            Console.WriteLine("Task4");
            Console.WriteLine("Task5");
            Console.WriteLine("Task6");
        }
        public async Task<int> Call1(string Filename)
        {

            int len = 0;
            using (StreamReader reader = new StreamReader(Filename))
            {
                string Words = await reader.ReadToEndAsync();  // contnt ina file , read
                len = Words.Length;
                Task.Delay(5000).Wait();
            }

            return len;
        }

        public async void Exe1()
        {
            string Filename = "C:\\Users\\m.a.khaja.moinuddin\\OneDrive - Accenture\\Desktop\\Myfile.txt";

            Task<int> result = Call1(Filename);
            Console.WriteLine("Task1");
            Console.WriteLine("Task2");
            Console.WriteLine("Task3");
            int finalresult = await result;
            Console.WriteLine("No of Words:" + finalresult); // 5 secods
            Console.WriteLine("Task4");
            Console.WriteLine("Task5");
            Console.WriteLine("Task6");
        }

    }
}
