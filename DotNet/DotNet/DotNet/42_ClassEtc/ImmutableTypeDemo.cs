
using System;

namespace ImmutableTypeDemo
{
    public class Circle
    {
        public int Radius { get; private set; } = 0;
        public Circle(int radius) => Radius = radius;
        public Circle MakeNew(int radius) => new Circle(radius);
    }

    class ImmutableTypeDemo
    {
        static void Main()
        {
            
            Circle circle = new Circle(10);
            Console.WriteLine($"Radius: {circle.Radius} - {circle.GetHashCode()}");

            
            circle = circle.MakeNew(20);
            Console.WriteLine($"Radius: {circle.Radius} - {circle.GetHashCode()}");
        }
    }
}