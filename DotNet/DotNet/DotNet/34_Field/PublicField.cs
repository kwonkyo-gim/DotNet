using System;

namespace PublicField
{
    class Category
    {
        public string CategoryName;
    }

    class PublicField
    {
        static void Main()
        {
            Category book = new Category();
            book.CategoryName = "책";
            Console.WriteLine(book.CategoryName);  
        }
    }
}