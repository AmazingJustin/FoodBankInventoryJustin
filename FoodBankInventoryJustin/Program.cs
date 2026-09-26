using System.Security.Cryptography;

namespace FoodBankInventoryJustin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Food food1 = new Food(101, "Canned Beans", "Canned Food", 24);
            Food food2 = new Food(102, "Tomato Soup", "Canned Food", 18);
            Food food3 = new Food(103, "White Rice", "Grains", 30);
            Food food4 = new Food(104, "Spaghetti", "Pasta", 15);
            Food food5 = new Food(105, "Peanut Butter", "Spreads", 12);

            List<Food> foods = new List<Food>();

            foods.AddRange(food1, food2, food3, food4, food5);
            Console.WriteLine("=== Community Food Bank Inventory System ===\n");

            int total  = 0;

            foreach (Food food in foods)
            {
                Console.WriteLine(food.Display());
                Console.WriteLine();
                total = total + food.Quantity;
            }

            Console.WriteLine($"Total inventory: {total} items");

            Console.WriteLine("\n--- Foods in Need of Restocking (<20 items) ---");

            foreach (Food food in foods)
            {
                if(food.Quantity < 20)
                Console.WriteLine(food.Display());
                Console.WriteLine();
            }
        }
    }
}
