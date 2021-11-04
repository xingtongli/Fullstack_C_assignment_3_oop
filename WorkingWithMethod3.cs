using System;
using System.Collections.Generic;

namespace wwm3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<DateTime> holidays = new List<DateTime>();
            holidays.Add(new DateTime(DateTime.Now.Year, 1, 1));
            holidays.Add(new DateTime(DateTime.Now.Year, 1, 18));
            holidays.Add(new DateTime(DateTime.Now.Year, 1, 20));
            holidays.Add(new DateTime(DateTime.Now.Year, 2, 15));
            holidays.Add(new DateTime(DateTime.Now.Year, 3, 31));
            holidays.Add(new DateTime(DateTime.Now.Year, 6, 18));
            holidays.Add(new DateTime(DateTime.Now.Year, 7, 5));
            holidays.Add(new DateTime(DateTime.Now.Year, 9, 6));
            holidays.Add(new DateTime(DateTime.Now.Year, 10, 11));
            holidays.Add(new DateTime(DateTime.Now.Year, 11, 11));
            holidays.Add(new DateTime(DateTime.Now.Year, 11, 25));
            holidays.Add(new DateTime(DateTime.Now.Year, 12, 24));

            DateTime first = getdate();
            DateTime last = getdate();

            int days = getdays(holidays, first, last);

            Console.WriteLine($"There are {days} working days.");

        }
        static DateTime getdate()
        {
            Console.WriteLine("Please enter date with /mm-dd-yyyy/ format:");
            string date = Console.ReadLine();
            string year = date.Substring(7,4);
            string md = date.Substring(1, 5);
            date = year + "-" + md;
    
            string pattern = "yyyy-MM-dd";
            DateTime parseDate;
            DateTime.TryParseExact(date, pattern, null, System.Globalization.DateTimeStyles.None, out parseDate);
            return parseDate;
        }
        static int getdays(List<DateTime> holidays, DateTime first, DateTime last)
        {
            int days = 0;
            for(DateTime date = first; date<=last; date = date.AddDays(1))
            {
                if((first.DayOfWeek != DayOfWeek.Saturday) && (first.DayOfWeek != DayOfWeek.Sunday) && (!holidays.Contains(date)))
                {
                    days++;
                }
                first = first.AddDays(1);
            }
            return days;
        }
    }
}
