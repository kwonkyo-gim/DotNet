using System;

class Constant
{
    static void Main()
    {
        string name = "박용준";
        name = "레드플러스";

        const int age = 20; 

        Console.WriteLine($"{name} - {age}");

        const double PI = 3.14;
        const string SITE_NAME = "닷넷코리아";

        Console.WriteLine($"{SITE_NAME}\n{PI} ");
    }
}