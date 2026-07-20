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
            Console.WriteLine("8. Swap_Two_Numbers(Without_Using_Third_Variable)");
            Console.WriteLine("0. Back");

            Console.Write("\nEnter Choice : ");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    _01_Hello_World.Run();
                    break;

                case 2:
                    _02_OddEven.Run();
                    break;

                case 3:
                    _03_Positive_Negative_Zero.Run();
                    break;

                case 4:
                    _04_Largest_of_Two_Numbers.Run();
                    break;

                case 5:
                    _05_Largest_of_Three_Numbers.Run();
                    break;

                case 6:
                    _06_Smallest_of_Three_Numbers.Run();
                    break;

                case 7:
                    _07_Swap_Two_Numbers.Run();
                    break;

                case 8:
                    _08_Swap_Two_Numbers.Run();
                    break;

                case 9:
                    _09_Leap_Year.Run();
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