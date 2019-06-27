using System;
using System.Collections.Generic;
using System.Linq;


namespace CSharpAdvApp
{
   public   class Student
    {
        public int StudentID { get; set; }
        public String StudentName { get; set; }
        public int Age { get; set; }
    }


    class _2LinqStudentDemo
    {


        public static void Main()
        {

            Student[] studentArray =
            {
            new Student() { StudentID = 1, StudentName = "John", Age = 18 },
            new Student() { StudentID = 2, StudentName = "Steve",  Age = 21 },
            new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 },
            new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 },
            new Student() { StudentID = 5, StudentName = "Ron" , Age = 31 },
            new Student() { StudentID = 6, StudentName = "Chris",  Age = 17 },
            new Student() { StudentID = 7, StudentName = "Rob",Age = 19  },


            };



           var students = studentArray.Where(s => s.Age > 12 && s.Age < 20).ToArray();

            var filteredResult = from s in studentArray
                                 where s.Age > 12 && s.Age < 20
                                 orderby s.Age descending
                                 select s.StudentName;


            foreach (var s in filteredResult)
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();

        }
    }
}
