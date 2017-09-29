
namespace IntervalofNumbers
{
    using System;
    public class StartUp
    {
        public static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (a < b)
            {
                for (int i = a; i <= b; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                for (int i = b; i <= a; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
