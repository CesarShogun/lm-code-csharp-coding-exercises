using System;
namespace Exercises.Models
{
    public class Person
    {

        public Person(string name, string surname, string birthplace, int age)
        {
            Name = name;
            Surname = surname;
            Birthplace = birthplace;
            Age = age;
        }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Birthplace { get; set; }

        public int Age { get; set; }
    }
}
