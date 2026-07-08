using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airplain__Rservation
{
    class Date
    {

        int Day;
        int Month;
        int Year;
        public  Date(int Day, int Month, int Year)
        {
            this.Day = Day;
            this.Month = Month;
            this.Year = Year;
        }
        public  Date()
        {
            Day = 0;
            Month = 0;
            Year = 0;
        }
        public Date(Date date)
        {
            this.Day = date.Day;
            this.Month = date.Month;
            this.Year = date.Year;
        }
        public void SetDay(int day)
        {
            if (day >= 1 && day <= 31)
                Day = day;
            else
                Console.WriteLine("Invalid day value. Must be between 1 and 31.");
        }

        public void SetMonth(int month)
        {
            if (month >= 1 && month <= 12)
                Month = month;
            else
                Console.WriteLine("Invalid month value. Must be between 1 and 12.");
        }

        public void SetYear(int year)
        {
            if (year > 2020)
                Year = year;
            else
                Console.WriteLine("Invalid year value. Must be positive.");
        }
        public void input()
        {
            Console.WriteLine("Enter the day");
            Day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the month");
           Month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the year");
            Year = Convert.ToInt32(Console.ReadLine());
        }
        public void Print()
        {
            Console.Write("Date: " + Day + "/" + Month + "/" + Year);
        }
    }

}
