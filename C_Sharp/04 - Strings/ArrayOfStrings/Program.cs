internal class Program
{
    private static void Main(string[] args)
    {
        // Create an array to hold 5 names
        string[] names = new string[5];

        // Prompt the user to enter 5 names and store them in the array
        for (int i = 0; i < names.Length; i++)
        {
            Console.WriteLine($"Enter name {i + 1}:");
            names[i] = Console.ReadLine();
        }

        // Print the names entered by the user
        Console.WriteLine("The names you entered are:");
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

        // Get the third letter of the second name and print it
        if (names.Length >= 2 && names[1].Length >= 3)
        {
            // Get the third letter of the second name and print it
            // names[1] is the second name, and we want the third letter (index 2) --> names[1][2]
            char thirdLetter = names[1][2];
            Console.WriteLine($"The third letter of the second name is: {thirdLetter}");
        }
        else
        {
            Console.WriteLine("The second name does not have a third letter.");
        }
    }
}

/*
Enter name 1:
Ruben
Enter name 2:
Frank
Enter name 3:
Mario
Enter name 4:
Kart
Enter name 5:
Worldwide
The names you entered are:
Ruben
Frank
Mario
Kart
Worldwide
The third letter of the second name is: a
*/