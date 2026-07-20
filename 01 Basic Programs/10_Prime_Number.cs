using System;

namespace CSharp_Practice._01_Basic_Programs
{
    class _10_Prime_Number
    {
        public static void Run()
        {
            int count = 0;

            Console.Write("Enter a Number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number <= 1)
            {
                Console.WriteLine($"{number} is Not a Prime Number.");
                return;
            }

            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    count++;
                }
            }

            if (count == 2)
            {
                Console.WriteLine($"{number} is a Prime Number.");
            }
            else
            {
                Console.WriteLine($"{number} is Not a Prime Number.");
            }
        }
    }
}