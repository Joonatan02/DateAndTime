using System;

namespace DateAndTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Today;
            Console.WriteLine($"Today: {today}");
            int yearToday = today.Year;
            Console.WriteLine($"Current year today: {yearToday}");
            var weekDayToday = today.DayOfWeek;
            Console.WriteLine($"Today is: {weekDayToday}!");
            Console.WriteLine(" ");

            DateTime todayDetails = DateTime.Now;
            Console.WriteLine($"Today in details: {todayDetails}");
            DateTime utc = DateTime.UtcNow;
            Console.WriteLine($"Todays details are {utc}");

            //DateTime (year, mounth, day, hour, minute)

            DateTime christmas = new DateTime(2020, 12, 24);
            var ChristmasDayOfWeek = christmas.DayOfWeek;
            Console.WriteLine($"This year christmas is on {ChristmasDayOfWeek}");

            //New project BirthdayOfWeek
            // the application asks the users date of birth
            // and displays the day of the week the user was born on

            Console.WriteLine("Enter your year of birth:");
            int year = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter your mounth of birth:");
            int mounth = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter your day of birth:");
            int date = Int32.Parse(Console.ReadLine());


            GetTheWeekDay(year, mounth, date);
                







        }
        public static void GetTheWeekDay(int year, int mounth, int date)
        {
            DateTime birthdate = new DateTime(year, mounth, date);
            var dayOfTheWeek = birthdate.DayOfWeek;
            Console.WriteLine($"Your were born on: {dayOfTheWeek}");
        }
    }
}
