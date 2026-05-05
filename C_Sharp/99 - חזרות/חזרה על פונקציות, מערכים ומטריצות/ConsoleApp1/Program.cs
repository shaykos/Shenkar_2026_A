using System.Reflection;
using System.Threading.Channels;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //תרגיל דוגמא - מכוניות
            //for (int i = 0; i < 5; i++)
            //{
            //    string[] det = CarDetails();
            //    PrintCars(det);
            //}

            // פתרון שאלה 2 ממבחן מהט
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int k = FindIndex(arr);
            Console.WriteLine($"k = {k}"); // k=6

        }

        //העמסת פונקציות - כאשר יש להן אותו שם ורק חתימת הפונקציה שונה
        static void PrintCars(int[] nums) //המערך נשלח לפונקציה by ref
        {

        }
        static void PrintCars()
        {

        }
        static void PrintCars(string[] str) //המערך נשלח לפונקציה by ref
        {
            foreach (string s in str)
            {
                Console.WriteLine(s);
            }
        }

        static string[] CarDetails()
        {
            string manufacturer, model;
            string year;

            string[] details = new string[3];

            Console.WriteLine("Enter manufacturer:");
            manufacturer = Console.ReadLine();

            Console.WriteLine("Enter model:");
            model = Console.ReadLine();

            Console.WriteLine("Enter year:");
            year = Console.ReadLine();

            for (int i = 0; i < details.Length; i++)
            {
                if (i == 0) details[i] = manufacturer;
                else if (i == 1) details[i] = model;
                else details[i] = year;
            }

            return details;
        }

        static int FindIndex(int[] arr)
        {

            for (int k = 1; k < arr.Length; k++)
            {
                int mLeft = CalcMulti(0, k - 1, arr);
                int mRight = CalcMulti(k + 1, arr.Length - 1, arr);
                if (mLeft == mRight)
                    return k;
            }

            return -1;
        }

        static int CalcMulti(int start, int end, int[] arr)
        {
            int res = 1;
            for (int i = start; i <= end; i++)
            {
                res *= arr[i];
            }
            return res;
        }

    }
}
