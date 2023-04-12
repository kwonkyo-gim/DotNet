using System;

class BitNot
{
    static void Main()
    {
        byte x = 0b00001010; // 10

        Console.WriteLine($"  {Convert.ToString(x, 2).PadLeft(8, '0')} -> {x, 3}");

        Console.WriteLine($"------");

        Console.WriteLine($"  {Convert.ToString((byte)~x , 2).PadLeft(8, '0')} -> {~x, 3}");
    
    }
}