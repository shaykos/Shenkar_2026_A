namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            //Destination destination = new Destination("Paris", 199.99, 5);
            //Console.Write(destination); // ToString אוטומטית מפעיל את הפונקציה

            //Console.WriteLine();

            Person yam = new Person("Blue", "Brown", 25);
            Person noam = new Person("Green", "Blonde", 30);
            Person adam = new Person(noam);

            int[] arr = new int[] { 1, 2, 3, 4, 5 };
            Person[] persons = new Person[] { yam, noam, adam };

            foreach (Person p in persons)
            {
                Console.WriteLine(p.age);
            }
            //-------------------------------------------------------
            for(int i=0; i < persons.Length; i++)
            {
                Console.WriteLine(persons[i].age);
            }

        }
    }
}
