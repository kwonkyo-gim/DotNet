using System;

class SignedInteger
{
    static void Main()
    {
        sbyte sb = 127;                 
        short st = 32767;               
        int i = Int32.MaxValue;          
        long l = Int64.MaxValue; 

        Console.WriteLine("{0} {1} {2} {3}", sb, st, i, l);
    }
}