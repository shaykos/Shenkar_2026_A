internal class Program
{
    private static void Main(string[] args)
    {
       int[] arr = {4, 3, 2, 7};

      Console.WriteLine($"There are {arr.Length} numbers in the array: ");
       for (int i=0 ; i < arr.Length ; i++)
       {
             Console.Write($"{arr[i]}: ");
             for (int j = 0; j < arr[i]; j++)
                   Console.Write("*");
	        Console.WriteLine();
	  }
	  Console.WriteLine();

    }
}