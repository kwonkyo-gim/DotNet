using System;

class TypeAssertion
{
    static void Main()
    {
        var number = 1234; 
        Console.WriteLine(number.GetType()); 

        var message = "안녕하세요."; 
        Console.WriteLine(message.GetType()); 
    }
}