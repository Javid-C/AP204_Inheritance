using System;
using System.Collections.Generic;
using System.Text;

namespace AP204_Inheritance
{
    class Human
    {
        public string Name;
        public string Surname;
        public byte Age;
        public string Gender;


        public Human(byte age)
        {
            Age = age;
        }
        public Human(string name)
        {
            Name = name;
        }
        public Human(string name,string surname,byte age,string gender)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Gender = gender;
        }
        public string Fullname()
        {
            return $"Name: {Name}, Surname: {Surname}";
        }
    }
}
