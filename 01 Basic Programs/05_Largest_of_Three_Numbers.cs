using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice._01_Basic_Programs
{
    class _05_Largest_of_Three_Numbers
    {
        public static void Run()
        {
            Console.WriteLine("Enter A Num 1");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter A Num 2");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter A Num 3");
            int num3 = Convert.ToInt32(Console.ReadLine());


            if (num1 == num2 && num1 == num3)
            {
                Console.WriteLine("All Are Same");
            }
            else if (num1 >= num2 && num1 >= num3)
            {
                Console.WriteLine($"{num1} is Large");
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                Console.WriteLine($"{num2} is Large");
            }
            else
            {
                Console.WriteLine($"{num3} is Large");
            }
            
        }
    }
}
