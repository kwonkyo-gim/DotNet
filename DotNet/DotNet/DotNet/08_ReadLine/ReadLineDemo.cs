using System;

class ReadLineDemo
{
    static void Main()
    {
        Console.WriteLine("정수: ");
        string num = Console.ReadLine();
        int number = Convert.ToInt32(num);
        Console.WriteLine(number + number);

    }
}