using System;
using System.Collections.Generic;
using System.Linq;


namespace CSharpAdvApp
{
    class FirstLinqDemo
    {
        public static void Main()
        {
            //data store
            string[] names = {"Ravi", "meena","Jagan", "Sameer" };

           var result = from name in names
                                         select name;

            
           foreach(var name in result)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
        }
    }
}
