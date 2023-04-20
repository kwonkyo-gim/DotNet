using System;
using System.Collections.Generic;


public class SignBase
{
    public int SignId { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
}


public class SignRepository
{
    public List<SignBase> GetAll()
    {
        var signs = new List<SignBase>()
        {
            new SignBase() { SignId = 1, Email = "a@a.com", Password = "1234" },
            new SignBase() { SignId = 2, Email = "b@b.com", Password = "2345" },
            new SignBase() { SignId = 3, Email = "c@c.com", Password = "3456" },
        };

        return signs;
    }
}


public class SignContext
{
    public List<SignBase> Signs
    {
        get
        {
            return (new SignRepository()).GetAll();
        }
    }
}


class SignBaseSignRepository
{
    static void Main()
    {
        var signs = (new SignContext()).Signs;

        foreach (var sign in signs)
        {
            Console.WriteLine($"{sign.SignId}, {sign.Email}, {sign.Password}");
        }
    }
}