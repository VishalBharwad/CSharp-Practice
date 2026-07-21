using System;

namespace CSharp_Practice._01_Basic_Programs
{
    class _11_Prime_Number_In_Range
    {
        public static void Run()
        {
            Console.Write("Enter Start Number: ");
            int start = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter End Number: ");
            int end = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nPrime Numbers are:");

            for (int i = start; i <= end; i++)
            {
                if (i <= 1)
                    continue;

                int count = 0;

                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                    }
                }

                if (count == 2)
                {
                    Console.Write(i + "-> Is Prime Number\n");
                }
                else
                {
                    Console.Write(i + "-> Is Not Prime Number\n");
                }
            }
        }
    }
}