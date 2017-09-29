namespace CountTheIntegers
{
    using System;
    public class StartUp
    {
        public static void Main()
        {
            int count = 0;

            while (true)
            {
                try
                {
                    int a = int.Parse(Console.ReadLine());
                    count++;
                }
                catch (Exception)
                {
                    Console.WriteLine(count);
                    break;
                }
            }
        }
    }
}
