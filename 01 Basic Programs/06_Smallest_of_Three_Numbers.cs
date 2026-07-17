using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice._01_Basic_Programs
{
    class _06_Smallest_of_Three_Numbers
    {
        public static void Run()
        {
            Console.WriteLine("Enter A Num 1");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter A Num 2");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter A Num 3");
            int num3 = Convert.ToInt32(Console.ReadLine());

            int smallest = Math.Min(num1, Math.Min(num2,num3));
            Console.WriteLine($"Smallest Value Is {smallest}");
        }
    }
}
