﻿using System;

namespace PropertyValidation
{
    class Car
    {
        public string Name { get; private set; }
        public Car(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException();
            }
            this.Name = name;
        }
    }

    class PropertyValidation
    {
        static void Main()
        {
            Car car = new Car("자동차");
            Console.WriteLine(car.Name); 

            
        }
    }
}