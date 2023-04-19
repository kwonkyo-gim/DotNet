
using System;

namespace VirtualOverride
{
   
    class Parent
    {
        
        public virtual void Work() => Console.WriteLine("프로그래머");
    }

   
    class Child : Parent
    {
      
        public override void Work() => Console.WriteLine("프로게이머");
    }

    class VirtualOverride
    {
        static void Main()
        {
           
            (new Parent()).Work();

            
            (new Child()).Work(); 
        }
    }
}