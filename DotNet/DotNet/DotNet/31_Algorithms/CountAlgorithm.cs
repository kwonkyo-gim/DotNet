using System;
using System.Linq;

class CountAlgorithm
{
    static void Main()
    {
        var numbers = Enumerable.Range(1, 1_000).ToArray();
        int count = default; 

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] % 13 == 0) 
            {
                count++; // 
            }
        }

        Console.WriteLine($"1부터 1,000까지의 정수 중 13의 배수의 개수: {count}");
    }
}
