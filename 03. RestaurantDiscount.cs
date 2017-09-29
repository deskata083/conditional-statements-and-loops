namespace RestaurantDiscount
{
    using System;
    public class StartUp
    {
       public  static void Main()
        {
            int people = int.Parse(Console.ReadLine());
            string service = Console.ReadLine();

            double price = 0;
            string hall = "";

            
            
            
            if(people>120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
            else if (people > 100)
            {
                hall = "Great Hall";
                price = 7500;
            }
            else if (people >50)
            {
                hall = "Terrace";
                price = 5000;
            }
            else
            {
                hall = "Small Hall";
                price = 2500;
            }


            if (service == "Normal")
            {
                price = price + 500;
                price = price * 0.95;
            }
            else if (service == "Gold")
            {
                price = price + 750;
                price = price * 0.9;
            }
            else if (service == "Platinum")
            {
                price = price + 1000;
                price = price * 0.85;
            }

            if (people <= 120)
            {
                price = price / people;
                Console.WriteLine($"We can offer you the {hall}\r\nThe price per person is {price:F2}$");
            }

        }
    }
}
