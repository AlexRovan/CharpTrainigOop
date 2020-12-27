﻿
namespace LambdaTask
{
    public class Person
    {
        public string Name { get; }

        public int Age { get; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return $"Имя {Name}, Возраст {Age}";
        }
    }
}
