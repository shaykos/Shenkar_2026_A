namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Destination destination = new Destination("Paris", 199.99, 5);
            Console.Write(destination); // ToString אוטומטית מפעיל את הפונקציה

            Console.WriteLine();
        }
    }
}
