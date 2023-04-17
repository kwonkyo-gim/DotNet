﻿using System;

class ParamsDemo
{
    static void Main()
    {
       
        Console.WriteLine(SumAll(3, 5)); 
        Console.WriteLine(SumAll(3, 5, 7)); 
        Console.WriteLine(SumAll(3, 5, 7, 9)); 
    }

  
    static int SumAll(params int[] numbers) 
    {
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        return sum;
    }
}