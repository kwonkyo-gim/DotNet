using System;

namespace VirtualOverrideBase
{
    class Parent
    {
        public virtual void Work() => Console.WriteLine("프로그래머");
    }

    class Child : Parent
    {
       
        public override sealed void Work() => base.Work();
    }

    class GrandChild : Child
    {
        
        public void Play() => Console.WriteLine("프로게이머");
    }

    class VirtualOverrideBase
    {
        static void Main()
        {
            (new Parent()).Work();      
            (new Child()).Work();       
            (new GrandChild()).Work();  
            (new GrandChild()).Play(); 
        }
    }
}