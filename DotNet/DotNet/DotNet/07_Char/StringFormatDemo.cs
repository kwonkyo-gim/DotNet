using System;

class StringFormatDemo
{
    static void Main()
    {
        string msg = string.Format("{0}님, {1}", "홍길동", "안녕하세요.");
        Console.WriteLine(msg); 
    }
}