using System;

namespace AP204_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Homeworks
            //Student student = new Student("Safiyya", "Faracova", "AP204", 81,true);
            //Console.WriteLine(student.isGradueted);

            //Console.WriteLine(student.Fullname());
            //student.getInfo();
            //student.checkExam();


            //int num = Convert.ToInt32(Console.ReadLine());
            //int copy = num;
            //int count = 3;
            //while (copy != 0)
            //{
            //    copy /= 10; // copy= copy/10
            //    count *= 10;
            //}
            //int result = num + count;
            //Console.WriteLine(result);
            //int[] arr = { 2, 4, 5, 600, 500,-2,7, -33, 66};

            //int max = Arr(arr);
            //Console.WriteLine(max);
            #endregion

            //Human human = new Human();

            //human.Age = 20;
            
            //Console.WriteLine(human.Age);

            //Student student = new Student("Bahadur", "Umarov", "AP204", 51, 19, "Male");
            
            //Console.WriteLine(student.Gender);

            Teacher teacher = new Teacher("Javid","Asadullayev",24,"Male",5670,"Programming");
            //Console.WriteLine(teacher.Fullname());

            Police police = new Police("Rashid","Mammadov",19,"Male","Narimanov");

            Console.WriteLine(police.Region);
        }

        #region Homeworks
        //public static int Arr(int[] arr)
        //{
        //    int max = arr[0];
        //    foreach (int num in arr)
        //    {
        //        if(num > max)
        //        {
        //            max = num;
        //        }

        //    }
        //    return max;
        //}
        #endregion
    }

}
