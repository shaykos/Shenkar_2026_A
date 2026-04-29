internal class Program
{
    private static void Main(string[] args)
    {
        const int EXIT = -1;
        int[] daysFrequency = new int[7];
        int day, max = 0;

        Console.Write($"Insert the day you like most (1-7), {EXIT} to EXIT: ");
        day = int.Parse(Console.ReadLine());
        while (day != EXIT)
        {
            if (day >= 1 && day <= 7)
                daysFrequency[day - 1]++;
            else
                Console.WriteLine("Invalid input.");
            
            Console.Write($"Insert the day you like most (1-7), {EXIT} to EXIT: ");
            day = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Each day and number of persons who liked it most:");
        for (int i = 1; i <= 7; i++)
            Console.WriteLine($"{i}: {daysFrequency[i - 1]}");

        for (int i = 0; i < 7; i++)
        {
            if (daysFrequency[i] > daysFrequency[max])
                max = i;
        }
        Console.WriteLine($"The favorite day is: {max + 1}");

    }
}