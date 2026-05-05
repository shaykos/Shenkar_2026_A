namespace Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Food יצירת מערך של 4 אובייקטים מטיפוס 
            Food[] foods = new Food[4];

            //קליטת נתונים ויצרית אובייקטים במערך
            for (int i = 0; i < foods.Length; i++)
            {
                Console.Write($"Food #{i + 1}\n----------------\nName: ");
                string name = Console.ReadLine();
                Console.Write("Food type (v/f/d/m/p): ");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Food weight: ");
                double weight = double.Parse(Console.ReadLine());

                Console.Write("has experation date? (y/n): ");
                char yesOrNo = char.Parse(Console.ReadLine());

                if (yesOrNo == 'n')
                {
                    foods[i] = new Food(name, type, weight);
                    continue;
                }

                Console.Write("Days to expired: ");
                int days = int.Parse(Console.ReadLine());

                foods[i] = new Food(name, type, weight, days);
            }

            Console.WriteLine("\n---------------\n");

            //מעבר על כל הנתונים והדפסת הפרטים שלהם
            foreach (Food food in foods)
            {
                Console.Write($"{food.GetName()}: ");
                food.PrintExperationDate();
            }
        }
    }
}
