﻿using System;

class DefaultParameter
{
    static void Main()
    {
        Log("디버그");        
        Log("에러", 4);       
    }

     static void Log(string message, byte level = 1)
    {
        Console.WriteLine($"{message}, {level}");
    }
}