using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTechCrew
{
    class Exception
    {
        public static void Div()
        {
        a:
            try
            {
                Console.WriteLine("Enter X");
                int x = Convert.ToInt32(Console.ReadLine());   //1
                Console.WriteLine("Enter y");
                int y = Convert.ToInt32(Console.ReadLine());  //2
                int z = x / y; //3  divie by zero

                int[] arr = { 34};
                Console.WriteLine(arr[10]);  // error
                Console.WriteLine($"Div is {z}");

                //errror here
            }
            

            catch (System.FormatException ex)  // tab
            {
                Console.WriteLine("format");
                Console.WriteLine(ex.Message);
                goto a;
            }
             
            catch (System.DivideByZeroException ex)  //tab
            {
                Console.WriteLine("divide");
                Console.WriteLine(ex.Message);
                goto a;
            }

            catch (System.IndexOutOfRangeException ex)  //tab
            {
                Console.WriteLine("array error");
                Console.WriteLine(ex.Message);
                goto a;
            }

            catch (System.Exception ex)  // tab
            {
                Console.WriteLine("exception");
                Console.WriteLine(ex.Message);
                goto a;
            }

        }
    }
}
