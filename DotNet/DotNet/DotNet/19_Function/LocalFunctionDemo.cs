using System;

class LocalFunctionDemo
{
    static void Main()
    {
        void Display(string text)
        {
            Console.WriteLine(text);
        }

        Display("로컬 함수");
    }
}