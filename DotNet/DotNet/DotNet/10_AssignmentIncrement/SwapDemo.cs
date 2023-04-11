using System;

class SwapDemo
{
    static void Main()
    {
        var i = 100;
        var j = 200;

        Console.WriteLine($"처음: {i}, {j}");

      
        var temp = i; 
        i = j; 
        j = temp; 

        Console.WriteLine($"변경: {i}, {j}");
    }
}