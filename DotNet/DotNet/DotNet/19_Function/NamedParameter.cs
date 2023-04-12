// 함수의 매개 변수 이름을 지정하여 호출하기 
using System;

class NamedParameter
{
    static void Main()
    {
        Sum(10, 20); 

        Sum(first: 10, second: 20); 

        Sum(second: 20, first: 10); 
    }

    static void Sum(int first, int second)
    {
        Console.WriteLine(first + second);
    }
}