using System;

class UnaryOperator
{
    static void Main()
    {
        int value = 0;

        value = 8; 
        value = +value; 
        Console.WriteLine(value); 

        value = -8; 
        value = +value; 
        Console.WriteLine(value); 

        value = 8; 
        value = -value; 
        Console.WriteLine(value); 

        value = -8; 
        value = -value; 
        Console.WriteLine(value); 
    }
}