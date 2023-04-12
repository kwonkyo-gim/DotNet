// MethodOverloadNumber.cs
// 메서드(함수) 오버로드(다중 정의) 
using System;

class MethodOverloadNumber
{
    static void GetNumber(int number)
    {
        Console.WriteLine($"Int32: {number}");
    }

    static void GetNumber(long number)
    {
        Console.WriteLine($"Int64: {number}");
    }

    static void Main()
    {
        GetNumber(1234);    
        GetNumber(1234L);   
    }
}