﻿using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Console.WriteLine(person.Age + ", " + person.Name);
        }
    }
}
