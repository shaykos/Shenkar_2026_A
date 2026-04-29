internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        string reversedTwoLetters = FirstLettersSwapper(name);
        Console.WriteLine(reversedTwoLetters);
    }

    static string FirstLettersSwapper(string name)
    {
        // This method swaps the first two letters of the input string and returns the modified string.
        string str = name[1].ToString() + name[0].ToString();

        // We start the loop from index 2 because we have already swapped the first two letters.
        for (int i = 2; i < name.Length; i++)
        {
            str += name[i];
        }
        return str;
    }
}