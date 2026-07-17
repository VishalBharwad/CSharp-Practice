using CSharp_Practice._01_Basic_Programs;

namespace CSharp_Practice;

public static class BasicMenu
{
    public static void Show()
    {
        while (true)
        {
            Console.Clear();

            Console.WriteLine("====== Basic Programs ======");

            Console.WriteLine("1. Hello World");
            Console.WriteLine("2. Odd Even");
            Console.WriteLine("3. Positive_Negative_Zero");
            Console.WriteLine("4. Largest_of_Two_Numbers");
            Console.WriteLine("5. Largest_of_Three_Numbers");
            Console.WriteLine("6. Smallest_of_Three_Numbers");
            Console.WriteLine("7. Swap_Two_Numbers(Using_Third_Variable)");
            Console.WriteLine("0. Back");

            Console.Write("\nEnter Choice : ");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Hello_World.Run();
                    break;

                case 2:
                    OddEven.Run();
                    break;

                case 3:
                    Positive_Negative_Zero.Run();
                    break;

                case 4:
                    Largest_of_Two_Numbers.Run();
                    break;

                case 5:
                    Largest_of_Three_Numbers.Run();
                    break;

                case 6:
                    Smallest_of_Three_Numbers.Run();
                    break;

                case 7:
                    Swap_Two_Numbers.Run();
                    break;

                case 0:
                    return;

                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
    }
}