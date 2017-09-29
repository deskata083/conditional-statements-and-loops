namespace CaloriesCounter
{
    using System;
    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string ingr = "";
            int calories = 0;

            for(int i = 1; i<=n; i++)
            {
                ingr = Console.ReadLine().ToLower();
                if(ingr == "cheese")
                {
                    calories += 500;
                }else if (ingr== "tomato sauce")
                {
                    calories += 150;
                }else if (ingr == "salami")
                {
                    calories += 600;
                }else if (ingr == "pepper")
                {
                    calories += 50;
                }
            }
            Console.WriteLine($"Total calories: {calories}");

        }
    }
}
