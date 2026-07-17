using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice._01_Basic_Programs
{
    class _04_Largest_of_Two_Numbers
    {
        public static void Run()
        {
            Console.WriteLine("Enter A Num 1");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter A Num 2");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if(num1 == num2)
            {
                Console.WriteLine("Both Are Same");
            }
            else if(num1 > num2)
            {
                Console.WriteLine($"{num1} is Large");
            }
            else
            {
                Console.WriteLine($"{num2} is Large");
            }
        }
    }
}
