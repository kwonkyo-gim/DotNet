using System;

class GetTypeDemo
{
    static void Main()
    {
        int i = 1234;               
        string s = "안녕하세요.";    
        char c = 'A';               
        double d = 3.14;            
        object o = new Object();    

        Console.WriteLine(i.GetType()); 
        Console.WriteLine(s.GetType()); 
        Console.WriteLine(c.GetType()); 
        Console.WriteLine(d.GetType()); 
        Console.WriteLine(o.GetType()); 
    }
}