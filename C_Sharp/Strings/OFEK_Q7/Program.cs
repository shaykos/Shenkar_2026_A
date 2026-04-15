internal class Program
{
    private static void Main(string[] args)
    {
        string name = Console.ReadLine();

        string reversedTwoLetters = FirstLettersSwapper(name);

        Console.WriteLine(reversedTwoLetters);
    }

    static string FirstLettersSwapper(string name)
    {
        string temp = name;

        string firstLetter = temp[0].ToString();
        string secondLetter = temp[1].ToString();

        Console.WriteLine($"{firstLetter} {secondLetter}");

        string swappedName = ""; //temp.Replace(firstLetter, secondLetter);
        swappedName += secondLetter;
        swappedName += firstLetter;
        swappedName += temp.Substring(2);

        return swappedName;
    }
}