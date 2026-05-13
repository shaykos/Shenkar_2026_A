namespace TarKita1;

internal class Program
{
    private static void Main(string[] args)
    {
        Point p1 = new Point(0, 0);
        Point p2 = new Point(5, 0);
        Point p3 = new Point(5, 5);

        Triangle tr = new Triangle(p1, p2, p3);

        Console.WriteLine(tr.ToString());

    }
}