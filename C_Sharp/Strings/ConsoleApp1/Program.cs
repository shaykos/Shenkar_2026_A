
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        Console.WriteLine($"Hello, {name}! your name has {name.Length} characters.");
        //name[0] = 'X'; // This will cause a compile-time error because strings are immutable in C#

        //count only the letters in the name
        int letterCount = 0;

        //נעבור באמצעות לולאה על כל תו במחרוזת ונבדוק האם הוא אות או לא
        //for(int i = 0; i < name.Length; i++){
        //    char c = name[i];
        //    if (c >= 'A' && c < 'Z' || c >= 'a' && c < 'z') //if(char.IsLetter(c))
        //    {
        //        letterCount++;
        //    }

        foreach (char c in name)
        {
            if (c >= 'A' && c < 'Z' || c >= 'a' && c < 'z') //if(char.IsLetter(c))
            {
                letterCount++;
            }

            //c = 'L'; // This will not change the original string, it will only change the value of c in this iteration of the loop
        }
        Console.WriteLine($"Your name has {letterCount} letters.");

        // Concatenation example
        int age = 30;
        string str = string.Concat("Hi ", name, " Your age is ", age.ToString());
        string str2 = $"Hi {name} Your age is {age}";
        Console.WriteLine(str);

        // Substring example
        string str3 = "!$$kudfdf$$$$$$$";
        string sub = str3.Substring(3, 5); //returns "kudfd"
        Console.WriteLine(sub);

        // Replace example
        string replaced = str3.Replace("$", " 7 "); //returns "!kudfdf"    
        Console.WriteLine(str3);
        Console.WriteLine(replaced);

        // Trim example
        string str4 = "   Hello World!   ";
        Console.WriteLine($"{str4}");
        Console.WriteLine($"{str4.Trim()}"); //returns "Hello World!" 
        // TrimStart() --> removes whitespace from the beginning of the string 
        // TrimEnd() --> removes whitespace from the end of the string

        // indexOf example
        string str5 = "Hello World";
        int index = str5.IndexOf("World"); //returns 6
        Console.WriteLine($"Index of 'World': {index}");
        
        int indexChar = str5.IndexOf('o'); //returns 4 (first occurrence)
        Console.WriteLine($"Index of 'o': {indexChar}");
        
        int notFound = str5.IndexOf("xyz"); //returns -1 (not found)
        Console.WriteLine($"Index of 'xyz': {notFound}");

        // Split example
        string str6 = "apple,banana,orange,grape";
        string[] fruits = str6.Split(','); //splits the string by comma
        Console.WriteLine("Fruits:");
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }
        
    }
}
