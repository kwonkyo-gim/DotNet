using System;

class DigitSeparatorDemo
{
    static void Main()
    {
        int bin = 0b0001_0001; 
        int dec = 1_000_000; 
        int hex = 0xA0_B0_C0; 

        Console.WriteLine(bin); 
        Console.WriteLine(dec); 
        Console.WriteLine(hex); 
    }
}