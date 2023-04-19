
using System;

class DynamicallyTypedObjects
{
    static void Main()
    {
        dynamic x = 1; 
        dynamic y = "Hello"; 

        Console.WriteLine($"x: {x}, {x.GetType()}");
        Console.WriteLine($"y: {y}, {y.GetType()}");
    }
}