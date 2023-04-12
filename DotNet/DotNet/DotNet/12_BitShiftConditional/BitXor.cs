using System;

class BitXor
{
    static void Main()
    {
        byte x = 0b1010; // 10
        byte y = 0b1100; // 12

        Console.WriteLine($"  {Convert.ToString(x, 2)} -> {x}");

        Console.WriteLine($"^ {Convert.ToString(y, 2)} -> {y}");

        Console.WriteLine($"------");

        Console.WriteLine($"  {Convert.ToString(x ^ y, 2).PadLeft(4, '0')} -> {x ^ y,2}");
    }
}