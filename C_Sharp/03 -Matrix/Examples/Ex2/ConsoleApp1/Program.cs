class Program
{
    static void Main(string[] args)
    {
        int[] arr = new int[] { 1, 2, 3, 4, 5, 6 };

        Console.WriteLine("The array is: ");
        PrintArray(arr);
        AddValueToArray(arr, 3);
        Console.WriteLine("\nThe array after add 3 to all its elements:");
        PrintArray(arr);
        Console.WriteLine();
    }

    static void PrintArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
            Console.Write($"{arr[i]} ");
    }

    static void AddValueToArray(int[] array, int val)
    {
        for (int i = 0; i < array.Length; i++)
            array[i] += val;
    }

}