using System;

class UnsignedInteger
{
    static void Main()
    {
        byte b = byte.MaxValue;               
        ushort s = ushort.MaxValue;                
        uint i = uint.MaxValue;          
        ulong l = ulong.MaxValue;

        Console.WriteLine("{0} {1} {2} {3}", b, s, i, l);
    }
}