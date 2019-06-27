using System;
using System.Collections.Generic;

namespace CSharpAdvApp
{

   
 public class Program04_Generics
    {


        public static void Main()
        {

            List<int> marks = new List<int>();
            marks.Add(45);
            marks.Add(455);
           //450000 times
            marks.Add(415);

            foreach(int i in marks)
            {
                Console.WriteLine(i);
            }


            Queue<string> names = new Queue<string>();
            names.Enqueue("Ravi");
            names.Enqueue("Raj");
            names.Enqueue("Savita");
            names.Enqueue("Shamala");
            names.Enqueue("Shivani");

            SortedList<int, string> sortedList1 = new SortedList<int, string>();
            sortedList1.Add(3, "Three");
            sortedList1.Add(4, "Four");
            sortedList1.Add(1, "One");
            sortedList1.Add(5, "Five");
            sortedList1.Add(2, "Two");


            IDictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "One");
            dict.Add(2, "Two");
            dict.Add(3, "Three");

            Console.WriteLine(dict[1]); //returns One
            Console.WriteLine(dict[2]); // returns Two


            IDictionary<int, Person> students = new Dictionary<int, Person>();


            students.Add(1, new Person { FirstName="Ravi", LastName="Tambade"});
            students.Add(2, new Person { FirstName = "Ravi", LastName = "Tambade" });
            students.Add(3, new Person { FirstName = "Ravi", LastName = "Tambade" });

            Console.WriteLine(students[1]); //returns One
            Console.WriteLine(students[2]); // returns Two



           
            Console.ReadLine();
        }
    }
}
