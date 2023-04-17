
using System;

namespace PublicAndPrivate
{
    public class Car
    {
     
        public static void Hi() { Console.WriteLine("Hi"); }
        private static void Bye() { Console.WriteLine("Bye"); }

        
        public static string name;   
        private static int age;      

        
        public static void SetAge(int intAge) { age = intAge; }
        public static int GetAge() { return age; }
    }

    class PublicAndPrivate
    {
        static void Main()
        {
            
            Car.Hi();

            

            
            Car.name = "RedPlus"; Console.WriteLine(Car.name);

            
            Car.SetAge(21);
            Console.WriteLine(Car.GetAge());
        }
    }
}