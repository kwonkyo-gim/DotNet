using System;




class RadixTransformation
{
    static void Main()
    {
      
        Console.WriteLine(
            $"십진수 10을 이진수로 변경: {Convert.ToString(10, 2)}"); 

   
        Console.WriteLine(
            $"이진수 1010을 십진수로 변경: {Convert.ToInt32("1010", 2)}");
    }
}