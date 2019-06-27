using System;

using System.Linq;


namespace CSharpAdvApp
{
  public  class Program06_Query
    {
       public static void Main()
        {
            string[] names = {"Amol", "Ravi", "Bill", "Steve", "James", "Mohan" };
            var myLinqQuery = from name in names
                              where name.Contains('a')
                              select name;
            foreach( var name in myLinqQuery)
            {
                Console.WriteLine(name + "  ");
            }

            Console.ReadLine();
        }
    }
}
