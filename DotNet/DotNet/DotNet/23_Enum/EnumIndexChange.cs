// <예제>열거형의 인덱스 순서 변경: EnumIndexChange.cs
using System;

enum Animal
{
    Horse,     
    Sheep = 5, 
    Monkey     
}

class EnumIndexChange
{
    static void Main()
    {
        Console.WriteLine((int)Animal.Monkey); 
    }
}