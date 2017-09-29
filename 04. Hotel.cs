namespace Hotel
{
    using System;
    public class StartUp
    {
        public static void Main()
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double prStudio = 0;
            double prDouble = 0;
            double prSuite = 0;

            double finalStudio = 0;
            double finalDouble = 0;
            double finalSuite = 0;

            switch (month)
            {
                case "May":
                case "October":
                    if (nights > 7)
                    {
                        prStudio = 50*0.95;
                        prDouble = 65;
                        prSuite = 75;
                    }
                    else 
                    {
                        prStudio = 50;
                        prDouble = 65;
                        prSuite = 75;
                    } break;
                case "June":
                case "September":
                    if (nights > 14)
                    {
                        prStudio = 60;
                        prDouble = 72*0.9;
                        prSuite = 82;
                    }
                    else
                    {
                        prStudio = 60;
                        prDouble = 72;
                        prSuite = 82;
                    }
                    break;
                case "July":
                case "August":
                case "December":
                    if (nights > 14)
                    {
                        prStudio = 68;
                        prDouble = 77;
                        prSuite = 89*0.85;
                    }
                    else
                    {
                        prStudio = 68;
                        prDouble = 77;
                        prSuite = 89;
                    }
                    break;
            }
            finalStudio = prStudio * nights;
            finalDouble = prDouble * nights;
            finalSuite = prSuite * nights;

            if (month == "September" && nights > 7)
            {
                finalStudio = finalStudio - 60;
            }
            if (month == "October" && nights > 7)
            {
                finalStudio = finalStudio - 50 * 0.95;
            }

            Console.WriteLine($"Studio: {finalStudio:F2} lv.\r\nDouble: {finalDouble:F2} lv.\r\nSuite: {finalSuite:F2} lv.");

        }
    }
}
