using CSharp_Practice;

while (true)
{
    Console.Clear();

    Console.WriteLine("========== C# Practice ==========");
    Console.WriteLine("1. Basic Programs");
    Console.WriteLine("2. String Programs");
    Console.WriteLine("3. Array Programs");
    Console.WriteLine("4. Pattern Programs");
    Console.WriteLine("5. OOP");
    Console.WriteLine("0. Exit");

    Console.Write("\nEnter Choice : ");

    int choice = Convert.ToInt32(Console.ReadLine());

    switch (choice)
    {
        case 1:
            BasicMenu.Show();
            break;

        case 2:
            // StringMenu.Show();
            break;

        case 3:
            // ArrayMenu.Show();
            break;

        case 4:
            // PatternMenu.Show();
            break;

        case 5:
            // OOPMenu.Show();
            break;

        case 0:
            return;

        default:
            Console.WriteLine("Invalid Choice");
            Console.ReadKey();
            break;
    }
}