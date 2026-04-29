internal class Program
{
    private static void Main(string[] args)
    {
        /*
            יש לכתוב תוכנית שמדמה את תהליך מתן תעודת הצטיינות לסטודנטים אשר ממוצע ציוניהם מעל 90. 
            התוכנית תקלוט כמה סטודנטים יש ולכל סטודנט יש לקלוט את שמו וכמות הציונים שיש לו. 
            יש לקלוט את הציונים של כל סטודנט ולחשב את הממוצע. 
            עליכם להשתמש במערך כדי לשמור את שמות הסטודנטים, את כמות הציונים שלהם ואת סך הציונים של כל סטודנט. 
            רמז: יהיו 3 מערכים כאשר האינדקס הראשון בכל מערך יהיה עבור הסטודנט הראשון, האינדקס השני עבור הסטודנט השני וכן הלאה. 
        */

        int[] studentGradesCount, studentGradesSum;
        string[] studentNames;

        Console.WriteLine("Enter the number of students:");
        int studentsCount = int.Parse(Console.ReadLine());

        studentNames = new string[studentsCount];
        studentGradesCount = new int[studentsCount];
        studentGradesSum = new int[studentsCount];

        for (int i = 0; i < studentsCount; i++)
        {
            Console.Write($"Enter the name of student {i + 1}: ");
            studentNames[i] = Console.ReadLine();

            Console.Write($"Enter the number of grades for {studentNames[i]}: ");
            studentGradesCount[i] = int.Parse(Console.ReadLine());

            // קולטים את הציונים של הסטודנט בהתאם לכמות שהזנו קודם ומחשבים את הסכום שלהם
            for (int j = 0; j < studentGradesCount[i]; j++)
            {
                Console.Write($"Enter grade {j + 1} for {studentNames[i]}: ");
                studentGradesSum[i] += int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("\nStudents with an average grade above 90:");
        for (int i = 0; i < studentsCount; i++)
        {
            double average = (double)studentGradesSum[i] / studentGradesCount[i];
            if (average > 90)
            {
                Console.WriteLine($"{studentNames[i]} - Average: {average:F2}");
            }
        }
    }
}

/*

Enter the number of students:
3
Enter the name of student 1: kuku
Enter the number of grades for kuku: 4
Enter grade 1 for kuku: 80
Enter grade 2 for kuku: 87
Enter grade 3 for kuku: 100
Enter grade 4 for kuku: 60
Enter the name of student 2: lulu
Enter the number of grades for lulu: 3
Enter grade 1 for lulu: 90
Enter grade 2 for lulu: 90
Enter grade 3 for lulu: 100
Enter the name of student 3: gogo
Enter the number of grades for gogo: 5
Enter grade 1 for gogo: 15
Enter grade 2 for gogo: 61
Enter grade 3 for gogo: 77
Enter grade 4 for gogo: 67 
Enter grade 5 for gogo: 79

Students with an average grade above 90:
lulu - Average: 93.33

*/