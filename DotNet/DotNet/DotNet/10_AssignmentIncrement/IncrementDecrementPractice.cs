using System;

class IncrementDecrementPractice
{
    static void Main()
    {
        int number1 = 3; 
        int number2 = 5; 

        int result1 = 0;
        int result2 = 0;

        number1--; 
        result1 = ++number1; 

        ++number2;
        result2 = number2--;

        Console.WriteLine(result1); 
        Console.WriteLine(result2); 
    }
}