
using System;
using System.Collections.Generic;

namespace CollectionInitializers
{
    class Person
    {
        public string Name { get; set; }
    }

    class CollectionInitializers
    {
        static void Main()
        {
            List<Person> people = new List<Person>
            {
                new Person { Name = "홍길동" },
                new Person { Name = "백두산" },
                new Person { Name = "임꺽정" }
            };

            foreach (var person in people)
            {
                Console.WriteLine(person.Name);
            }
        }
    }
}