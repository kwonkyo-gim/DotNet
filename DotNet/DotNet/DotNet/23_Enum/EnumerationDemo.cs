﻿using System;

enum Priority
{
    High,
    Normal,
    Low
}

class EnumerationDemo
{
    static void Main()
    {
        Priority high = Priority.High; 
        Priority normal = Priority.Normal;
        Priority low = Priority.Low;

        Console.WriteLine($"{high}, {normal}, {low}");
    }
}