using System;
using CollegeLib;

namespace ReflectionDemo
{

   
    public class Test
    {
        public static void Main()
        {
            Book theBook = new Book
            {
                Title = "Let us c",
                Author = "Yashwant Kanetkar",
                Publication = "Orelly"
            };
            Console.WriteLine(theBook);
            //At runtime invoking metada of
            // class, instance, lib
            // is called Reflection

            Type t = theBook.GetType();
            Console.WriteLine(t.Name);
            Console.WriteLine(t.Namespace);
            Console.WriteLine(t.Module);
            Console.ReadLine();
        }
    }
}