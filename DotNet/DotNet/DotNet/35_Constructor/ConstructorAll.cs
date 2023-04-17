﻿using System;

namespace ConstructorAll
{
    public class Person
    {
        private static readonly string _Name;
        private int _Age;


        static Person() { _Name = "홍길동"; }
        public Person() { _Age = 21; }
        public Person(int _Age)
        {
            this._Age = _Age; 
        }

        
        public static void Show()
        {
            Console.WriteLine("이름 : {0}", _Name);
        }
        
        public void Print()
        {
            Console.WriteLine("나이 : {0}", _Age);
        }
    }
    class ConstructorAll
    {
        static void Main()
        {
            
            Person.Show();

            
            (new Person()).Print(); 
            (new Person(22)).Print();
        }
    }
}