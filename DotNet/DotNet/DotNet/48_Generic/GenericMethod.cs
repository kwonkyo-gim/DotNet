using System;

namespace DotNet
{
    
    public class Hello<T>
    {
        private T _message; 
        public Hello() { _message = default(T); } 
        public Hello(T message) { this._message = message; } 
        public void Say(T message) =>
            Console.WriteLine("{0}", message); 
        public T GetMessage() => this._message; 
    }

    class GenericMethod
    {
        static void Main()
        {
           
            Hello<int> hi = new Hello<int>();
            hi.Say(1234);
            Hello<string> hs = new Hello<string>();
            hs.Say("안녕");
        }
    }
}