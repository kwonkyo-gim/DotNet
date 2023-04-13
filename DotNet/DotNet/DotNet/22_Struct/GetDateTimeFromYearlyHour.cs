using System;

class GetDateTimeFromYearlyHour
{
    static void Main()
    {
        Console.WriteLine(GetDateTimeFromYearlyHourNumber(1));
        Console.WriteLine(GetDateTimeFromYearlyHourNumber(8760 / 2));
        Console.WriteLine(GetDateTimeFromYearlyHourNumber(8760));
    }

    static DateTime GetDateTimeFromYearlyHourNumber(int number)
    {
        return (new DateTime(2019, 1, 1, 0, 0, 0)).AddHours(--number);
    }
}