using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_OOP.ThirdProject
{
    internal class Duration
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }


        public Duration(int hours, int minutes , int seconds)
        {
            Hours = hours; 
            Minutes = minutes;
            Seconds = seconds;
            Normalize();

        }

        

        public Duration(int totalSeconds)
        {
            Hours = totalSeconds / 3600;
            Minutes = (totalSeconds % 3600) / 60;
            Seconds = totalSeconds % 60;
            Normalize();
        }

        private void Normalize()
        {
            if (Seconds >= 60)
            {
                Minutes += Seconds / 60;
                Seconds %= 60;
            }

            if (Minutes >= 60)
            {
                Hours += Minutes / 60;
                Minutes %= 60;
            }
        }

        public override string ToString()
        {
            return $" Hours: {Hours}, Minutes :{Minutes}, Seconds :{Seconds}";
        }

        

        public override bool Equals(object? obj)
        {
            if (obj == null || obj.GetType() != typeof(Duration))
                return false;

            Duration other = (Duration)obj;

            return this.Hours == other.Hours &&
              this.Minutes == other.Minutes &&
              this.Seconds == other.Seconds;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Hours, Minutes, Seconds);
        }
        public static explicit operator Duration(int value)
        {
            return new Duration(value);
        }
        public static Duration operator +(Duration a, Duration b)
        {
            //    return new Duration(a.Hours + b.Hours, a.Minutes + b.Minutes, a.Seconds + b.Seconds);
            int totalSeconds = a.ToTotalSeconds() + b.ToTotalSeconds();
        return new Duration(totalSeconds);
        }



        public static Duration operator -(Duration a, Duration b)
        {
            //return new Duration(a.Hours - b.Hours, a.Minutes - b.Minutes, a.Seconds - b.Seconds);
            int totalSeconds = a.ToTotalSeconds() - b.ToTotalSeconds();
            return new Duration(totalSeconds);

        }

        public static Duration operator +(Duration a, int second)
        {

            int totalSecond = a.ToTotalSeconds() + second;
            return new Duration(totalSecond);

        }

        public static Duration operator +(int second , Duration a)
        {

            int totalSecond = a.ToTotalSeconds() + second;
            return new Duration(totalSecond);

        }

        public static Duration operator ++(Duration a)
        {

            int totalSecond = a.ToTotalSeconds();
            a.Minutes += 1;
            return new Duration(totalSecond);

        }

        public static Duration operator --(Duration a)
        {

            int totalSecond = a.ToTotalSeconds();
            a.Minutes -= 1;
            return new Duration(totalSecond);

        }

        public static bool operator <(Duration a , Duration b)
        {

            if (a.Hours > b.Hours)
                return (a.Minutes <= b.Minutes);
            else
                return (a.Hours <= b.Hours);
        }

        public static bool operator >(Duration a, Duration b)
        {

            if (a.Hours == b.Hours)
                return (a.Minutes > b.Minutes);
            else
                return (a.Hours > b.Hours);
        }

        public static bool operator <=(Duration a, Duration b)
        {

            if (a.Hours == b.Hours)
                return (a.Minutes > b.Minutes);
            else
                return (a.Hours > b.Hours);
        }

        public static bool operator >=(Duration a, Duration b)
        {

            if (a.Hours == b.Hours)
                return (a.Minutes > b.Minutes);
            else
                return (a.Hours > b.Hours);
        }

        public static implicit operator bool(Duration d)
        {
           
            return d.Hours > 0 || d.Minutes > 0 || d.Seconds > 0;
        }

        public static explicit operator DateTime(Duration d)
        {

            return new DateTime(1970, 1, 1).AddSeconds(d.Hours * 3600 + d.Minutes * 60 + d.Seconds);
        }
        private int ToTotalSeconds()
        {
            return Hours * 3600 + Minutes * 60 + Seconds;
        }
    }
}
