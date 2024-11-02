using System;

namespace DateUtilities
{
    public class DateCalculator
    {
        // Adding Days to a Date
        public DateTime AddDays(DateTime date, int days)
        {
            return date.AddDays(days);
        }

        // Subtracting Days from a Date
        public DateTime SubtractDays(DateTime date, int days)
        {
            return date.AddDays(-days);
        }

        // Calculating Days Between Two Dates
        public int DaysBetween(DateTime startDate, DateTime endDate)
        {
            return (endDate - startDate).Days;
        }

        // Determining the Day of the Week
        public string GetDayOfWeek(DateTime date)
        {
            return date.DayOfWeek.ToString();
        }

        // Checking if a Year is a Leap Year
        public bool IsLeapYear(int year)
        {
            return DateTime.IsLeapYear(year);
        }
    }
}
