using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice._01_Basic_Programs
{
    class _07_Swap_Two_Numbers
    {
        public static void Run()
        {
            Console.WriteLine("Enter A Num 1");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter A Num 2");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Before Swap Num 1 :{num1} & Num 2 :{num2}");

            int x = num1;
            num1 = num2;
            num2 = x;

            Console.WriteLine($"After Swap Num 1 :{num1} & Num 2 :{num2}");
        }
    }
}
