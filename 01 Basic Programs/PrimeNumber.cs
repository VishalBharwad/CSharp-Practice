namespace CSharp_Practice;

public static class PrimeNumber
{
    public static void Run()
    {
        Console.Clear();

        Console.WriteLine("===== Prime Number Program =====");

        Console.Write("Enter a Number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        bool isPrime = true;

        if (number <= 1)
        {
            isPrime = false;
        }
        else
        {
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
        }

        if (isPrime)
            Console.WriteLine($"{number} is a Prime Number.");
        else
            Console.WriteLine($"{number} is Not a Prime Number.");
    }
}