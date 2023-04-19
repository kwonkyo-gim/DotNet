
using System;

namespace GenericClass
{
    
    public class Cup<T>
    {
        public T Content { get; set; }
    }

    class GenericClass
    {
        static void Main()
        {
            
            Cup<string> text = new Cup<string>();
            text.Content = "문자열"; 

             
            Cup<int> number = new Cup<int>();
            number.Content = 1234; 

            Console.WriteLine($"{text.Content}, {number.Content}");
        }
    }
}