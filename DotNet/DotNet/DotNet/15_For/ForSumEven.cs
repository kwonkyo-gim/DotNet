﻿using System;

class ForSumEven
{
    static void Main()
    {
        int n = 5;
        int sum = 0;

        for (int i = 1; i <= n; i++) 
        {
            if (i % 2 == 0)
            {
                sum += i; 
            }
        }

        Console.WriteLine($"1부터 {n}까지 짝수의 합: {sum}");
    }
}