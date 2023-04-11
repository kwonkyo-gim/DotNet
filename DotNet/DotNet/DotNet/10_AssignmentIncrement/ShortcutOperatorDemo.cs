using System;

class ShortcutOperatorDemo
{
    static void Main()
    {
        int a = 3;
        int b = 5;

        b += a;

        Console.WriteLine("{0}", b);

       

        b -= a; 
        Console.WriteLine("{0}", b); 
    }
}
