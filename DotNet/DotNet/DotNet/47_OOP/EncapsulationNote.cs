﻿
using System;

namespace EncapsulationNote
{
    public class Person
    {
        
        private string name;
        
        public void SetName(string n) => name = n;
        public string GetName() => this.name;
    }
    class EncapsulationNote
    {
        static void Main()
        {
            
            Person person = new Person();
            
            person.SetName("C#");
            
            Console.WriteLine(person.GetName());
        }
    }
}