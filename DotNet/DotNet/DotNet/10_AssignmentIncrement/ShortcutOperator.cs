using System;

class ShortcutOperator
{
    static void Main()
    {
        int x = 3;
        int y = 3;

        x = x + 2; 
        y += 2; 

        Console.WriteLine($"x: {x}, y: {y}");
    }
}