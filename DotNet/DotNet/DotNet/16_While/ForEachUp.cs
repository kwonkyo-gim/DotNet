using System;

class ForEachUp
{
    static void Main()
    {
        var str = "abc123";

        foreach (var c in str)   //var 변수
        {
            Console.Write($"{c}\t");
        }
        Console.WriteLine();
    }
}