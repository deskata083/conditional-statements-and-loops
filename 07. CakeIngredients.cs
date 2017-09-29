namespace CakeIngredients
{
    using System;
    public class StartUp
    {
        public static void Main()
        {
            string ingr = "";

            int count = 0;

            while (ingr != "Bake!") 
           {
                if (ingr.Length > 2)
                {
                    Console.WriteLine($"Adding ingredient {ingr}.");
                }
                ingr = Console.ReadLine();
                if (ingr != "Bake!")
                {
                    count++;
                }
                    
            }
                       
            Console.WriteLine($"Preparing cake with {count} ingredients.");
        }
    }
}
