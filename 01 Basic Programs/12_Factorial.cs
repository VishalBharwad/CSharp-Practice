using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice._01_Basic_Programs
{
    class _12_Factorial
    {
        public static void Run()
        {
            Console.Write("Enter Factorial Number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int ans = 1;

            for (int i = 1; i<=num; i++)
            {
                
                    ans =ans * i;
            }

            Console.Write($"{num} Factorial = {ans}");
        }
    }
}
