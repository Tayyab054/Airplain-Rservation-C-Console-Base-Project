using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airplain__Rservation
{
    class Time
    {
        int Hour;
        int Minute;
        int Second;

        public Time(Time time)
        {
            Hour = time.Hour;
            Minute = time.Minute;
            Second = time.Second;
        }

        public Time(int hour, int minute, int second)
        {
            Hour = hour;
            Minute = minute;
            Second = second;
        }
        public void SetHour(int hour)
        {
            if (hour >= 0 && hour < 24)
                Hour = hour;
            else
            {
                Console.WriteLine("Invalid hour value. Must be between 0 and 23.");
            }
        }
        public void SetMinute(int minute)
        {
            if (minute >= 0 && minute < 60)
                Minute = minute;
            else
            {
                Console.WriteLine("Invalid minute value. Must be between 0 and 59.");
            }
        }
        public void SetSecond(int second)
        {
            if (second >= 0)
            {
                Minute += second / 60;
                Second = second % 60;
                Hour += Minute / 60;
                Minute %= 60;
                Hour %= 24;
            }
            else
            {
                Console.WriteLine("Invalid seconds value. Must be non-negative.");
            }
        }
        public void input()

        {
            Console.WriteLine("Enter houre");
            Hour = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Minut");
            Minute = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second");
            Second= Convert.ToInt32(Console.ReadLine());
        }
        public void Print()
        {
            Console.Write(Hour + ":" + Minute + ":" + Second);
        }
    }
}
