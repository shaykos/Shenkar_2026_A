class Program
{
    static void Main(string[] args)
    {
        #region Sum of digits
        // Console.Write("Please enter a two digits number: ");
        // int n = int.Parse(Console.ReadLine());
        // int result = SumDigits(n);
        // Console.WriteLine(result);
        #endregion

        #region Average of three numbers
        Console.WriteLine("Please enter three numbers: ");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        double avg = Average(b, c, a);
        Console.WriteLine($"The average of {a}, {b} and {c} is: {avg:F2}");
        #endregion
    }

    static int SumDigits(int num)
    {
        //num % 10 -> gives the last digit of the number
        //num / 10 -> gives the number without the last digit
        int sum = num % 10 + num / 10;
        return sum;
    }

    static double Average(int a, int b, int c)
    {
        double avg = (a + b + c) / 3.0;
        return avg;
    }
}
