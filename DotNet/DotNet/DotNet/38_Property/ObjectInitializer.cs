
using System;

namespace ObjectInitializer
{
    class Course
    {
        public int Id { get; set; } 
        public string Title { get; set; } 
    }

    class ObjectInitializer
    {
        static void Main()
        {
            
            Course csharp = new Course(); csharp.Id = 1; csharp.Title = "C#";
            Console.WriteLine($"{csharp.Id} - {csharp.Title}");

            
            Course aspnet = new Course() { Id = 2, Title = "ASP.NET" };
            Console.WriteLine($"{aspnet.Id} - {aspnet.Title}");
        }
    }
}