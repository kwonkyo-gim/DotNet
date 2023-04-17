// Object Initializer: 개체 이니셜라이저
using System;

namespace ObjectInitializerNote
{
    class ObjectInitializerNote
    {
        static void Main()
        {
           
            Person p1 = new Person();
            p1.Name = "홍길동";
            p1.Age = 21;
            Console.WriteLine($"이름: {p1.Name}, 나이: {p1.Age}, 타입: {p1.Type}");

            
            Person p2 = new Person() { Name = "백두산", Age = 99 };
            Console.WriteLine($"이름: {p2.Name}, 나이: {p2.Age}, 타입: {p2.Type}");
        }
    }
}