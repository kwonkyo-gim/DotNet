using System;


public class BaseClass
{
    public void Do() => Console.WriteLine("Base 클래스에 정의된 메서드");
}


public class SubClass : BaseClass { } 

class BaseSub
{
    static void Main()
    {
        var sub = new SubClass();
        sub.Do(); 
    }
}