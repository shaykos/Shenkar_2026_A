using System;

static class Program
{
    static void Main(string[] args)
    {
        MenuManager();
    }

    static void PrintMenu()
    {
        Console.WriteLine("1. Numbers Triangle");
        Console.WriteLine("2. Reversed Number");
        Console.WriteLine("3. Sum Of Digits");
        Console.WriteLine("4. Compare Numbers");
        Console.WriteLine("5. Exit");
    }

    static void MenuManager()
    {
        int choice;
        while (true)
        {
            Console.Clear(); // --> מנקה את המסך לפני הצגת התפריט מחדש
            PrintMenu();
            Console.Write("Enter your choice: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter the range: ");
                    int range = int.Parse(Console.ReadLine());
                    NumbersTriangle(range);
                    break;
                case 2:
                    Console.WriteLine(2);
                    break;
                case 3:
                    Console.WriteLine(3);
                    break;
                case 4:
                    Console.WriteLine(4);
                    break;
                case 5:
                    Console.WriteLine("Exiting...");
                    return; // --> יוצא מהתוכנית
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(); // --> ממתינים ללחיצת מקש כדי להמשיך
        }
    }

    static void NumbersTriangle(int range)
    {
        Console.Write(range);
        // השלימו את הפונקציה בהתאם להנחיות
    }
}