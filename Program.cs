using System;

namespace DateUtilities
{
    class Program
    {
        static void Main(string[] args)
        {
            DateCalculator calculator = new DateCalculator();

            DateTime today = DateTime.Now;
            Console.WriteLine($"Today's Date: {today}");

            // Adding Days
            DateTime futureDate = calculator.AddDays(today, 10);
            Console.WriteLine($"Date in 10 Days: {futureDate}");

            // Subtracting Days
            DateTime pastDate = calculator.SubtractDays(today, 5);
            Console.WriteLine($"Date 5 Days Ago: {pastDate}");

            // Days Between Dates
            int daysBetween = calculator.DaysBetween(pastDate, futureDate);
            Console.WriteLine($"Days Between {pastDate.ToShortDateString()} і {futureDate.ToShortDateString()}: {daysBetween}");

            // День тижня
            string dayOfWeek = calculator.GetDayOfWeek(today);
            Console.WriteLine($"Today is the Day of the Week: {dayOfWeek}");

            // Перевірка на високосний рік
            int year = 2024;
            bool isLeap = calculator.IsLeapYear(year);
            Console.WriteLine($"{year} Is it a Leap Year? {isLeap}");
        }
    }
}
