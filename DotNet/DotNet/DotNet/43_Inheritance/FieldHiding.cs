﻿using System;

namespace FieldHiding
{
    class Parent
    {
        private string _word;

        protected string Word
        {
            get { return _word; }
            set { _word = value; }
        }
    }

    class Child : Parent
    {
        public void SetWord(string word)
        {
            base.Word = word;
        }
        public string GetWord()
        {
            return Word; 
        }
    }

    class FieldHiding
    {
        static void Main()
        {
            Child child = new Child();
            child.SetWord("필드 숨기기 및 자식 클래스에게만 멤버 상속하기");
            Console.WriteLine(child.GetWord());
        }
    }
}