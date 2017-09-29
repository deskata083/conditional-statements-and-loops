namespace ChooseADrink
{
    using System;
    public class StartUp
    {
        public static void Main()
        {
            string prof = Console.ReadLine();
            int quant = int.Parse(Console.ReadLine());

            double price = 0;

            if (prof == "Athlete")
            {
                price = quant * 0.7;
            }
            else if (prof == "Businessman" || prof == "Businesswoman")
            {
                price = quant;
            }
            else if (prof == "SoftUni Student")
            {
                price = quant * 1.7;
            }
            else 
            {
                price = quant * 1.2;
            }
            Console.WriteLine($"The {prof} has to pay {price:F2}.");
        }
    }
}
