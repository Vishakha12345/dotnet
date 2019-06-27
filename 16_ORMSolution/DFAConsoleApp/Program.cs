using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFAConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var db = new ContentDBEntities())
            {

                //Create and save  a new blog
                Console.WriteLine("Enter a name for an new Blog :");
                var name = Console.ReadLine();
                var blog = new Blog { Name = name };

                db.Blogs.Add(blog);
                db.SaveChanges();

                //display  all blogs from the database

                var query = from b in db.Blogs
                            orderby b.Name
                            select b;

                Console.WriteLine("All blogs in the database:");
                foreach (var item in query)
                {
                    Console.WriteLine(item.Name);
                }

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }


        }
    }
}
