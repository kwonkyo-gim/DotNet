
using System;

namespace AbstractClassShape
{
    
    public abstract class Shape
    {
        
        public abstract double GetArea();
    }

    
    public class Square : Shape
    {
        private int _size;

        public Square(int size)
        {
            _size = size;
        }

       
        public override double GetArea()
        {
            return _size * _size;
        }
    }

    class AbstractClassShape
    {
        static void Main()
        {
            
            Square square = new Square(10);
            Console.WriteLine(square.GetArea()); 

            
            Shape shape = new Square(5);
            Console.WriteLine(shape.GetArea()); 
        }
    }
}