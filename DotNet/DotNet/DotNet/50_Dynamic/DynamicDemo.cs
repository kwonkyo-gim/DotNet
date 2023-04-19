
using System;

class DynamicDemo
{
    static void Main()
    {
        string ss = "안녕하세요."; 
        Console.WriteLine(ss.Length); 

        var vs = "반갑습니다."; 
        Console.WriteLine(vs.Length); 

        dynamic ds = "또 만나요.";
        Console.WriteLine(ds.Length); 

        ds = 1234; 
        Console.WriteLine(ds * 10); 
    }
}