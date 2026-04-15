
namespace ArraysAndFunctionsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // --- בדיקות לפונקציות ---

            // שאלה 1
            int[] arr1 = { -5, 10, 3, -1, 8 };
            Console.WriteLine($"Q1: Sum of positive numbers: {SumPositive(arr1)}"); // Expected: 21

            // שאלה 2
            int[] arr2 = { 15, 2, 88, 41, 6 };
            Console.WriteLine($"Q2: Max value: {FindMax(arr2)}"); // Expected: 88

            // שאלה 3
            int[] arr3 = { 1, 2, 3, 4, 5 };
            ReverseArray(arr3);
            Console.WriteLine($"Q3: Reversed array: {string.Join(", ", arr3)}"); // Expected: 5, 4, 3, 2, 1

            // שאלה 4
            int[,] matrix1 = {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };
            Console.WriteLine($"Q4: Diagonal sum: {DiagonalSum(matrix1)}"); // Expected: 15 (1+5+9)

            // שאלה 5
            int[] arr4 = { 1, 2, 3, 2, 1 };
            Console.WriteLine($"Q5: Is Palindrome? {IsPalindrome(arr4)}"); // Expected: True

            // שאלה 6
            int[,] matrix2 = {
                { 1, 9, 3 },
                { 4, 2, 6 },
                { 10, 8, 5 }
            };
            int[] rowMaxes = GetRowMaxes(matrix2);
            Console.WriteLine($"Q6: Row maxes: {string.Join(", ", rowMaxes)}"); // Expected: 9, 6, 10

            // שאלה 7
            int[,] grades = {
                { 80, 90, 85 }, // Average: 85
                { 95, 100, 90 },// Average: 95
                { 70, 75, 80 }  // Average: 75
            };
            Console.WriteLine($"Q7: Best student index: {GetBestStudentIndex(grades)}"); // Expected: 1
        }

        // פתרון שאלה 1: סכום חיוביים
        static int SumPositive(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    sum += arr[i];
                }
            }
            return sum;
        }

        // פתרון שאלה 2: מציאת מקסימום
        static int FindMax(int[] arr)
        {
            // אתחול המקסימום לאיבר הראשון כדי למנוע שגיאות עם מספרים שליליים
            int max = arr[0]; 
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }

        // פתרון שאלה 3: היפוך מערך In-Place
        static void ReverseArray(int[] arr)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left < right)
            {
                // החלפת משתנים באמצעות משתנה עזר
                int temp = arr[left];
                arr[left] = arr[right];
                arr[right] = temp;

                left++;
                right--;
            }
        }

        // פתרון שאלה 4: סכום אלכסון ראשי
        static int DiagonalSum(int[,] mat)
        {
            int sum = 0;
            // מכיוון שהמטריצה ריבועית, מספר השורות זהה למספר העמודות
            int size = mat.GetLength(0); 
            
            // לולאה אחת יעילה מספיקה! התא הוא תמיד [i, i]
            for (int i = 0; i < size; i++)
            {
                sum += mat[i, i];
            }
            return sum;
        }

        // פתרון שאלה 5: בדיקת פולינדרום
        static bool IsPalindrome(int[] arr)
        {
            // מספיק לרוץ עד אמצע המערך
            for (int i = 0; i < arr.Length / 2; i++)
            {
                // השוואת האיבר הנוכחי מול האיבר המקביל לו מהסוף
                if (arr[i] != arr[arr.Length - 1 - i])
                {
                    return false; // ברגע שמצאנו אי התאמה, זה לא פולינדרום
                }
            }
            return true;
        }

        // פתרון שאלה 6: מקסימום בכל שורה
        static int[] GetRowMaxes(int[,] mat)
        {
            int rows = mat.GetLength(0);
            int cols = mat.GetLength(1);
            int[] maxArr = new int[rows]; // יצירת מערך התוצאה בגודל מספר השורות

            for (int i = 0; i < rows; i++)
            {
                int currentMax = mat[i, 0]; // אתחול מקסימום לאיבר הראשון בשורה הנוכחית
                for (int j = 1; j < cols; j++)
                {
                    if (mat[i, j] > currentMax)
                    {
                        currentMax = mat[i, j];
                    }
                }
                maxArr[i] = currentMax; // שמירת המקסימום של השורה במערך התוצאה
            }
            return maxArr;
        }

        // פתרון שאלה 7: הסטודנט המצטיין
        static int GetBestStudentIndex(int[,] grades)
        {
            int studentsCount = grades.GetLength(0);
            int subjectsCount = grades.GetLength(1);

            int bestStudentIndex = 0;
            double highestAverage = -1; // אתחול לערך נמוך

            for (int i = 0; i < studentsCount; i++)
            {
                int sum = 0;
                for (int j = 0; j < subjectsCount; j++)
                {
                    sum += grades[i, j];
                }
                
                double average = (double)sum / subjectsCount;

                if (average > highestAverage)
                {
                    highestAverage = average;
                    bestStudentIndex = i; // שמירת האינדקס של הסטודנט המוביל
                }
            }
            return bestStudentIndex;
        }
    }
}
