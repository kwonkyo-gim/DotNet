using System;

class FunctionAddNumbers
{
    static int AddNumbers(int a, int b)
    {
        return a + b;
    }

    static void Main()
    {
        int a = 3;
        int b = 5;
        int c = AddNumbers(3, 5);
        Console.WriteLine($"{a} + {b} = {c}");
    }
}