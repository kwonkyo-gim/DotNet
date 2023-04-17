
using System;

namespace ConstructorMethod
{
    class Student
    {
        public Student()
        {
            Console.WriteLine("Student 개체가 생성됩니다.");
        }
    }

    class ConstructorMethod
    {
        static void Main()
        {
            Student student;
            student = new Student(); 
        }
    }
}