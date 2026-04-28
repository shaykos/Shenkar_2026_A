namespace Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] colors;

            Console.Write("How many players: ");
            int players = int.Parse(Console.ReadLine());

            // יוצרים את מערך הצבעים
            colors = new string[players];

            //מפעילים פונקציה שמאפשרת לשמחקנים לבחור את הצבע שלהם
            GetColorsFromPlayers(colors);

            //פונקציה שמתחילה את המשחק
            StartGame(colors);
        }

        static void GetColorsFromPlayers(string[] colors)
        {
            for (int i = 0; i < colors.Length; i++)
            {
                Console.Write($"Player #{i + 1}: ");
                colors[i] = Console.ReadLine();
            }

            Console.WriteLine("Done!");
        }

        static void StartGame(string[] colors)
        {
            //מערך ששומר את כמות ההגרלות שיצאו לכל צבע
            int[] counts = new int[colors.Length];

            string input;
            int index;
            Random rnd = new Random();

            do { 
                index = rnd.Next(0, colors.Length);
                Console.WriteLine(colors[index]);
                counts[index]++;
                Console.Write("to stop enter 'q': ");
                input = Console.ReadLine();
            } while (input != "q");

            //נדפיס את תוצאות ההגרלה
            for (int i = 0; i < counts.Length; i++)
            {
                Console.WriteLine($"{colors[i]}: {counts[i]}");
            }
        }
    }
}
