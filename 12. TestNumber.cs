namespace TestNumber
{
    using System;
    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int boundary = int.Parse(Console.ReadLine());

            int totalSum = 0;
            int count = 0;

            for (int i = n; i > 0; i--)
            {
                if (totalSum >= boundary)
                {
                    break;
                }
                for (int j = 1; j <= m; j++)
                {
                    totalSum += 3 * i * j;
                    count++;

                    if (totalSum >= boundary)
                    {
                        break;
                    }
                }
            }
            if (totalSum >= boundary)
            {
                Console.WriteLine($"{count} combinations\r\nSum: {totalSum} >= {boundary}");
            }
            else
            {
                Console.WriteLine($"{count} combinations\r\nSum: {totalSum}");
            }
        }
    }
}
