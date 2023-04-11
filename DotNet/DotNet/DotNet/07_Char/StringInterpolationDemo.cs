using System;

class StringInterpolationDemo
{
    static void Main()
    {
        string name = "C#";
        string version = "8.0";
        Console.WriteLine("{0} {1}", name, version);    

        string result = String.Format("{0} {1}", name, version);

        Console.WriteLine(result);  
        
        //편리하다.
        Console.WriteLine($"{name} {version}");

      
    }
}