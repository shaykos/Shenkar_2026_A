internal class Program
{
    private static void Main(string[] args)
    {
        const int NUM_CLASSES = 2;
        const int STUDENTS_IN_CLASS = 3;

        int[,] grades = new int[NUM_CLASSES, STUDENTS_IN_CLASS];
        double[] averageGrade = new double[NUM_CLASSES];

        //קליטת ציונים עבור כל הכיתות והסטודנטים
        Console.WriteLine($"Please enter grades for students in {NUM_CLASSES} classes:");
        for (int i = 0; i < NUM_CLASSES; i++)
        {
            Console.WriteLine($"Please enter grades for {STUDENTS_IN_CLASS} students in class #{i + 1}:");
            for (int j = 0; j < STUDENTS_IN_CLASS; j++)
                grades[i, j] = int.Parse(Console.ReadLine());
        }

        //חישוב הממוצע של כל כיתה
        for (int i = 0; i < NUM_CLASSES; i++)
        {
            int sum = 0;
            for (int j = 0; j < STUDENTS_IN_CLASS; j++)
                sum += grades[i, j];
            averageGrade[i] = (double)sum / STUDENTS_IN_CLASS;
        }

        // הצגת הציונים של כל הכיתות והסטודנטים
        Console.WriteLine("The grades in all classes:");
        for (int i = 0; i < NUM_CLASSES; i++)
        {
            Console.Write($"Class #{i + 1}: ");
            for (int j = 0; j < STUDENTS_IN_CLASS; j++)
                Console.Write($"{grades[i, j]} ");
            Console.WriteLine();
        }

        // הצגת הממוצע של כל כיתה
        Console.WriteLine("The average grade for each class:");
        for (int i = 0; i < NUM_CLASSES; i++)
        {
            Console.WriteLine($"Class #{i + 1}: {averageGrade[i]:F2}");
        }

        //הצגת כל הציונים הגבוהים מהממוצע הכיתתי
        Console.WriteLine("Grades above the class average:");
        for (int i = 0; i < NUM_CLASSES; i++)
        {
            Console.Write($"Class #{i + 1}: ");
            for (int j = 0; j < STUDENTS_IN_CLASS; j++)
            {
                if (grades[i, j] > averageGrade[i])
                    Console.Write($"{grades[i, j]} ");
            }
        }
    }
}       