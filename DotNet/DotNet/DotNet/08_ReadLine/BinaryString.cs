using System;

class BinaryString
{
    static void Main()
    {
        byte x = 10; 

 
        Console.WriteLine(
            $"십진수: {x} -> 이진수: {Convert.ToString(x, 2).PadLeft(8, '0')}");
    }
}