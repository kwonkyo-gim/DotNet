using System;

class KeyboardInput
{
    static void Main()
    {
        Console.WriteLine("아무키나 누르세요.");
  
        ConsoleKeyInfo cki = Console.ReadKey(true);
        Console.WriteLine("{0}", cki.Key); 
        Console.WriteLine("{0}", cki.KeyChar); 
        Console.WriteLine("{0}", cki.Modifiers); 
        if (cki.Key == ConsoleKey.Q)
        {
            Console.WriteLine("Q를 입력하셨군요...");
        }
    }
}