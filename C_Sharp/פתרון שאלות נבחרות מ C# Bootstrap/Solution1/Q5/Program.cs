
namespace Q5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] rooms;
            int numOfRooms;

            //מסננת קלט
            do
            {
                Console.Write("Enter num of rooms: ");
                numOfRooms = int.Parse(Console.ReadLine());
            } while (!(numOfRooms > 0 && numOfRooms <= 50)); //while (numOfRooms > 50 || numOfRooms < 0);

            //יצירת המערך בגודל שנקלט
            rooms = new int[numOfRooms];

            //יצירת נקודת ההתחלה
            int startPoint = 0;

            //Console.WriteLine($"before the CreateMaze function: {startPoint}");

            //הפעלת פונקציה ששמה מספרים במערך
            CreateMaze(rooms, ref startPoint);

            //Console.WriteLine($"after the CreateMaze function: {startPoint}");

            StartHunt(rooms, startPoint);
        }

        static void CreateMaze(int[] rooms, ref int startPoint)
        {
            Console.Write($"The current starting point is {startPoint}. if you want to change it, just do it: ");
            startPoint = int.Parse(Console.ReadLine());
            int currentRoom = startPoint;

            while (currentRoom != -1) {
                Console.Write($"from room {currentRoom} they should go to room: ");
                int nextRoom = int.Parse(Console.ReadLine());
                rooms[currentRoom] = nextRoom;
                currentRoom = nextRoom;
            }

            Console.WriteLine("We can start the game");
        }

        static void StartHunt(int[] rooms, int startPoint)
        {
            int current = startPoint;

            while (rooms[current] != -1)
            {
                Console.WriteLine($"{current} --> {rooms[current]}");
                current = rooms[current];
            }
        }
    }
}
