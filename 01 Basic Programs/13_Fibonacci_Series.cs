using System;

namespace CSharp_Practice._01_Basic_Programs
{
    class _13_Fibonacci_Series
    {
        public static void Run()
        {
            Console.Write("Enter Number of Terms: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int fib1 = 0;
            int fib2 = 1;
            int ans;

            if (num <= 0)
            {
                Console.WriteLine("Please enter a positive number.");
            }
            else if (num == 1)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.Write("0 1 ");

                for (int i = 3; i <= num; i++)
                {
                    ans = fib1 + fib2;
                    Console.Write(ans + " ");

                    fib1 = fib2;
                    fib2 = ans;
                }
            }
        }
    }
}