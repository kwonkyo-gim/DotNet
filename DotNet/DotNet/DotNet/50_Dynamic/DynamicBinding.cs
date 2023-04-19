using System;

class DynamicBinding
{
    static void Main()
    {
        
        dynamic now = DateTime.Now;
        int hour = now.Hour;
        Console.WriteLine(hour);
        Console.WriteLine(now.NoProperty); 
    }
}