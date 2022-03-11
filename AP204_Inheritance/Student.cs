using System;
using System.Collections.Generic;
using System.Text;

namespace AP204_Inheritance
{
    class Student:Human
    {
        //public string Name;
        //public string Surname;
        public string Group;
        public byte Point;
        public bool isGradueted;

        public Student(string name, string surname,string group,byte point, byte age,string gender, bool isgradueted=false):base(name,surname,age,gender)
        {
            Group = group;
            Point = point;
            isGradueted = isgradueted;
           
        }

        //public string Fullname()
        //{
        //    return $"Name: {Name}, Surname: {Surname}";
        //}

        public void getInfo()
        {
            if (isGradueted)
            {
                Console.WriteLine($"Name: {Name}, Surname: {Surname}, Group: {Group}, Point: {Point}, Mezun olub");
            }
            else
            {
                Console.WriteLine($"Name: {Name}, Surname: {Surname}, Group: {Group}, Point: {Point}, Mezun olmayib");
            }
        }

        public void checkExam()
        {
            if(Point > 80 && Point<100)
            {
                Console.WriteLine("Novbeti imtahana haqq qazandiniz");
            }
            else
            {
                Console.WriteLine("Get ishinle mesgul ol");
            }
        }
    }
}
