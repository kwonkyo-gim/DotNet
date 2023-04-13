using System;

class OutVariableDemo
{
    static void Main()
    {
        if (DateTime.TryParse("2020/12/25", out var xmas))
        {
            Console.WriteLine(xmas);
        }

        if (!DateTime.TryParse("20200707", out DateTime doubleSeven))
        {
            doubleSeven = DateTime.Now; 
        }
        Console.WriteLine(doubleSeven); 
    }
}