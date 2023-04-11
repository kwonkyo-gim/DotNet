using System;

class NumberToString
{
    static void Main()
    {
        int days = 28;

     
        Console.WriteLine("2월달은 " + days + "일입니다.");


        Console.WriteLine("2월달은 " + days.ToString() + "일입니다.");
        Console.WriteLine("2월달은 " + Convert.ToString(days) + "일입니다.");
    }
}