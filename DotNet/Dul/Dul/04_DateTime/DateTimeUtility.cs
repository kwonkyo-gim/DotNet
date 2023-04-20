using System;
using System.Collections.Generic;

namespace Dul
{
 
    public class DateTimeUtility
    {
        
        public static string ShowTimeOrDate(object dt, string format = "yyyy-MM-dd")
        {
            if (dt != null && DateTime.TryParse(dt.ToString(), out DateTime dateTime))
            {
                if (dateTime.Date == DateTime.Now.Date)
                {
                    return dateTime.ToString("hh:mm:ss");
                }
                else
                {
                    return dateTime.ToString(format); 
                }
            }
            else
            {
                return "";
            }
        }

        public static string ShowDate(object dt, string format = "yyyy-MM-dd")
        {
            if (dt != null && DateTime.TryParse(dt.ToString(), out DateTime dateTime))
            {
                return dateTime.ToString(format); 
            }
            else
            {
                return "";
            }
        }

        public static DateTime GetDateTimeFromYearlyHourNumber(int number)
        {
            return (new DateTime(2019, 1, 1, 0, 0, 0)).AddHours(--number);
        }

        public static int GetYearlyHourByDateTime(int month, int day, int hour)
        {
            int yearlyHour = 0;

            yearlyHour = (int)(new DateTime(2019, month, day, hour, 0, 0)
                - new DateTime(2019, 1, 1, 0, 0, 0)).TotalHours;

            return ++yearlyHour;
        }

        public static SortedList<int, double> GetTwelveMonthEmptyCollection()
        {
            SortedList<int, double> months = new SortedList<int, double>();

            for (int i = 1; i <= 12; i++)
            {
                months.Add(i, 0.0); 
            }

            return months;
        }

        public static SortedList<int, double> GetOneYear8760TimeEmptyCollection()
        {
            SortedList<int, double> oneYear = new SortedList<int, double>();

            for (int i = 1; i <= 8760; i++)
            {
                oneYear.Add(i, 0.0); 
            }

            return oneYear;
        }
    }
}