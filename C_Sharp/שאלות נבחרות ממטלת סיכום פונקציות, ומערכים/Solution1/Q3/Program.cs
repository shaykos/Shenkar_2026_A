namespace Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bool[,] matrix = {
            //    { true, false, false, false },
            //    { false, true ,true, false},
            //    { false, true, false, true},
            //    { false, true, true, false},
            //    { false, false, false, false}
            //};

            //int[,] board = CreateBoard(matrix);

            //PrintBoard(board);



            //מחלקות וקלאסים
            Person p1 = new Person("hfsjkd...,,,hjkhjk", 750, 'M', true); //Person - Type | p1 - name of property | new - Creates a new memory space for p1 | Person() - Constructor
            Person p2 = new Person(); //בונים אובייקט/מימוש/מופע של מחלקה/קלאס

            Console.WriteLine(p1.GetHasGlasses());

            p1.SetAge(55);
            Console.WriteLine(p1.GetAge());

            p1.SetAge(98);
            Console.WriteLine(p1.GetAge());
            //p3.Person(); //ניסיון קריאה לבנאי לאחר יצירת אובייקט - לא עובד. בנאי יוצר אובייקט פעם אחת וזהו

            //string n = Console.ReadLine();

            //Console.WriteLine(p1.GetName());

            //p1.name - קריאה לערך
            //p1.SetName() - קריאה לפונקציה
            //פונקציה חייבת להיכתב עם סוגריים. תכונה תהיה ללא סוגריים - לעולם !


            
        }

        static void Test() { }
        static void Test(int x) { }
        static int Test(double x) { return 0; }


        static int[,] CreateBoard(bool[,] matrix)
        {
            int[,] board = new int[matrix.GetLength(0), matrix.GetLength(1)];

            FindMines(board, matrix);

            FillCells(board);

            return board;
        }

        static void FindMines(int[,] board, bool[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    if (matrix[r, c] == true)
                    {
                        board[r, c] = -1;
                    }
                }
            }
        }

        static void FillCells(int[,] board)
        {
            int rows = board.GetLength(0);
            int cols = board.GetLength(1);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    if (board[r, c] != -1)
                    {
                        board[r, c] = CountMines(board, r, c);
                    }
                }
            }
        }

        static int CountMines(int[,] board, int r, int c)
        {
            int count = 0;

            /*
             
             *       0       0       0
             0       *       *       0
             0       *       0       *
             0       *       *       0
             0       0       0       0

             */

            //בדיקת התאים בשורה הנוכחית
            if (c - 1 >= 0 && board[r, c - 1] == -1) count++;
            if (c + 1 < board.GetLength(1) && board[r, c + 1] == -1) count++;

            //בדיקת תאים בשורה למעלה
            if (r - 1 >= 0)
            {
                //שורה מעל באותו התא
                if (board[r - 1, c] == -1) count++;

                //שורה מעל ותא באלכסון שמאלה
                if (c - 1 >= 0)
                {
                    if (board[r - 1, c - 1] == -1) count++;
                }

                //שורה מעל ותא באלכסון ימינה
                if (c + 1 < board.GetLength(1) && board[r - 1, c + 1] == -1) count++;
            }

            //בדיקת תאים בשורה למטה
            if (r + 1 < board.GetLength(0))
            {
                //שורה למטה ובאותו בתא
                if (board[r + 1, c] == -1) count++;

                //שורה למטה ותא באלכסון שמאלה
                if (c - 1 >= 0)
                {
                    if (board[r + 1, c - 1] == -1) count++;
                }

                //שורה למטה ותא באלכסון ימינה
                if (c + 1 < board.GetLength(1) && board[r + 1, c + 1] == -1) count++;
            }

            return count;
        }

        //פונקציה שמדפיסה את לוח המשחק
        static void PrintBoard(int[,] board)
        {

            for (int r = 0; r < board.GetLength(0); r++)
            {
                for (int c = 0; c < board.GetLength(1); c++)
                {
                    Console.Write(board[r, c] == -1 ? "* " : $"{board[r, c]} ");
                }
                Console.WriteLine();
            }
        }
    }
}

