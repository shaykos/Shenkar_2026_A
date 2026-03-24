using System.ComponentModel;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(IsOrderNumber(4421244));
        CreateSortedRandomNumber(1, 6, 4);
        CreateSortedRandomNumber2(1, 6, 4);
    }

    static bool IsOrderNumber(int num)
    {
        int current, prev = num % 10;
        num /= 10;
        while (num > 0)
        {
            current = num % 10;
            if (prev % 2 == 0 && current % 2 == 1)
                return false;
            prev = current;
            num /= 10;
        }
        return true;
    }

    static void CreateSortedRandomNumber(int x, int y, int len)
    {
        Random rnd = new Random();
        int evenCount = 0, oddCount = 0, evenNum = 0, oddNum = 0;
        while (evenCount + oddCount < len)
        {
            int digit = rnd.Next(x, y + 1);
            if (digit % 2 == 0)
            {
                evenNum *= 10;
                evenNum += digit;
                evenCount++;
            }
            else
            {
                oddNum *= 10;
                oddNum += digit;
                oddCount++;
            }
        }
        int newNum = evenNum * (int)Math.Pow(10, oddCount) + oddNum;
        //example: x = 1, y = 6, len = 4
        //random digits: 1, 3, 5, 6
        //evenNum = 6, oddNum = 135, evenCount = 1, oddCount = 3
        //newNum = 6 * 1000 + 135 = 6135
        Console.WriteLine(newNum);
    }

    static void CreateSortedRandomNumber2(int x, int y, int len)
    {
        Random rnd = new Random();
        while (true)
        {
            int number = 0;
            int tempLen = len;
            while (tempLen > 0)
            {
                int digit = rnd.Next(x, y + 1);
                number *= 10;
                number += digit;
                tempLen--;
            }
            if (IsOrderNumber(number))
            {
                Console.WriteLine(number);
                break;
            }
        }
    }
}