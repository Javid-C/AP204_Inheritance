using System;
using System.Collections.Generic;
using System.Text;

namespace AP204_Inheritance
{
    class Teacher:Human
    {
        public string Profession;
        public int Salary;


        public Teacher(string name,string surname,byte age,string gender,int salary,string profession):base(name,surname,age,gender)
        {
            Salary = salary;
            Profession = profession;
        }
        
    }
}
