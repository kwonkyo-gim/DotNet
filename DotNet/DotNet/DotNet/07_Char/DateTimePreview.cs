using System;

class DateTimePreview
{
    static void Main()
    {
        Console.WriteLine(DateTime.Now);

        Console.WriteLine($"{DateTime.Now.Year}-{DateTime.Now.Month}-{DateTime.Now.Day}");
        Console.WriteLine($"{DateTime.Now.Hour}:{DateTime.Now.Minute}:{DateTime.Now.Second}");
    }
}