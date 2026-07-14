using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CSharp_Practice._01_Basic_Programs
{
    class Positive_Negative_Zero
    {
        public static void Run()
        {
            Console.WriteLine("Enter A Number");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number == 0)
                Console.WriteLine("The Number Is Zero");
            else if (number > 0)
                Console.WriteLine("The Number Is Positive");
            else 
                Console.WriteLine("The Number Is Negative");
        }
    }
}
