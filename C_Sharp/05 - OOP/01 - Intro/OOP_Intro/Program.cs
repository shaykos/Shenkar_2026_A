using OOP_Intro;

internal class Program
{
    private static void Main(string[] args)
    {
        Student student1 = new Student("kuku lulu", 20);
        Student student2 = new Student("momo gogo", 25, new double[] { 90.7, 85, 92.1 });

        Student[] students = { student1, student2 };

        foreach (Student student in students)
        {
            Console.WriteLine($"Name: {student.GetName()}");
            Console.WriteLine($"Age: {student.GetAge()}");
            Console.WriteLine($"Grades Average: {student.GetAverageGrade():F3}");
            Console.WriteLine();
        }

    }
}