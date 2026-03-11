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
        int n1 = int.Parse(Console.ReadLine());
        int n2 = int.Parse(Console.ReadLine());
        int n3 = int.Parse(Console.ReadLine());
        double avgCalc = Average(n1, n2, n3);
        Console.WriteLine($"The average of {n1}, {n2} and {n3} is: {avgCalc:F2}");
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
