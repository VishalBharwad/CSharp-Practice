using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice._04_PatternPrograms
{
    class _02_Rectangle_Pattern
    {

        public static void Run()
        {
            Console.Write("Enter Number Of Row: ");
            int row = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Number Of Column: ");
            int col = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= col; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

    }
}
