// <예제> 클래스와 멤버 생성: ClassAndMember.cs
using System;

public class ClassName
{
    public static void MemberName()
    {
        Console.WriteLine("클래스의 멤버가 호출되어 실행됩니다.");
    }
}

public class ClassAndMember
{
    public static void Main()
    {
        ClassName.MemberName(); 
    }
}