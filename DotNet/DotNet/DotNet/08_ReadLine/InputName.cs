using System;

class InputName
{
    static void Main()
    {
        Console.Write("이름 : ______\b\b\b\b\b\b");
        string name = Console.ReadLine();
        Console.WriteLine($"{name}님 안녕하세요.");
    }
}