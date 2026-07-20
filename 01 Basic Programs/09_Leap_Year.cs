using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice._01_Basic_Programs
{
    class _09_Leap_Year
    {
        public static void Run()
        {
            Console.WriteLine("Enter A Year");
            int num1 = Convert.ToInt32(Console.ReadLine());

            if (num1%4==0 && num1%100==0 || num1%400==0)
            {
                Console.WriteLine($"{num1} Year Is Leap Year");
            }
            else
            {
                Console.WriteLine($"{num1} Year Is Not Leap Year");
            }
        }
    }
}
