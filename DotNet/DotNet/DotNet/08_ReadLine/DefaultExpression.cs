using System;
using System.Text;

class DefaultExpression
{
    static void Main()
    {
       
        int intDefault = default(int);
        bool boolDefault = default(bool); 
        string strDefault = default(string); 
        StringBuilder sbDefault =
            default(StringBuilder); 

        Console.WriteLine(intDefault); 
        Console.WriteLine(boolDefault); 
        Console.WriteLine(strDefault);
        Console.WriteLine(sbDefault); 
        Console.WriteLine(sbDefault == null); 
    }
}