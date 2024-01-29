﻿using System.Diagnostics.Metrics;

namespace Zadanie_domowe
{
    public abstract class Person
    {        
        public Person(string name, string surname, char sex)
        {
            this.Name = name;
            this.Surname = surname;
            this.Sex = sex;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public char Sex { get; private set;}

    }
}
