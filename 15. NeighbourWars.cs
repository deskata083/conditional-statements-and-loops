namespace NeighbourWars
{
    using System;
    public class StartUp
    {
        public static void Main()
        {
            int pDamage = int.Parse(Console.ReadLine());
            int gDamage = int.Parse(Console.ReadLine());

            int pHealth = 100;
            int gHealth = 100;
            int turn = 0;

            while (pHealth > 0 && gHealth > 0)
            {
                turn++;
                if (turn % 2 != 0)
                {
                    gHealth -= pDamage;
                    if (gHealth < 1)
                    {
                        Console.WriteLine($"Pesho won in {turn}th round.");
                        break;
                    }
                    Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {gHealth} health.");
                }
                else
                {
                    pHealth -= gDamage;
                    if (pHealth < 1)
                    {
                        Console.WriteLine($"Gosho won in {turn}th round.");
                        break;
                    }
                    Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {pHealth} health.");
                }
                if (turn % 3 == 0)
                {
                    pHealth += 10;
                    gHealth += 10;

                }
            }

        }
    }
}
