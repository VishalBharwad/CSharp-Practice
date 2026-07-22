using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp_Practice._01_Basic_Programs;
using CSharp_Practice._04_PatternPrograms;

namespace CSharp_Practice.Menus
{
    class _04_PatternPrograms
    {
        public static void Show()
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("====== Pattern Programs ======");

                Console.WriteLine("01. Square_Star_Pattern");
                Console.WriteLine("02. Square_Star_Pattern");

                Console.WriteLine("0. Back");

                Console.Write("\nEnter Choice : ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        _01_Square_Star_Pattern.Run();
                        break;

                    case 2:
                        _02_Rectangle_Pattern.Run();
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
}