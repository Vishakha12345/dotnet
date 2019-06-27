using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using System.Web.UI;

namespace FileIOTest
{
    class Program
    {
        static void Main(string[] args)
        {
           //WriteAllLines();
          // ReadAllData();
           //ReadAllLines();
           //CreateFile();
           //AppendFile();
           //InterpolateString();
           //WriteHTML();

            Console.ReadLine();
        }
   

        static void  WriteAllLines()
        {   // Write a string array to a file.
            string[] courses = new string[]
            { "CSharp","Java", "BigData" };
            File.WriteAllLines("file.txt", courses);
        }
   
        static void ReadAllData()
        {
            string file = File.ReadAllText("file.txt");
            Console.WriteLine(file);
        }

        static void ReadAllLines()
        {
            string[] lines = File.ReadAllLines("file.txt");
            foreach (string line in lines)
            {
                // Do something with the line.
                if (line.Length > 80)
                {
                    // Important code.
                }
                Console.WriteLine(line);
            }
        }

        static void CreateFile()
        {
            using (StreamWriter writer = new StreamWriter("important.txt"))
            {
                writer.Write("Transflower");
                writer.WriteLine("Welcomes");
                writer.WriteLine("you!");

            }

            //Dot net Framework initernally invokes Dispose()
            //Explicity Resource Releasing


        }
        static void AppendFile()
        {   // Write single line to new file.
            using (StreamWriter writer = new StreamWriter("log.txt", true))
            {    writer.WriteLine("Doing Ordinary Things extra ordinarily");
                    

            }
            // Append line to the file.
            using (StreamWriter writer = new StreamWriter("log.txt", true))
            {    writer.WriteLine("First Thing First");  }
        }

        static void InterpolateString()
        {
            using (StreamWriter writer = new StreamWriter("file.txt"))
            {
                string company = "Transflower Rating";
                int rating = 12;
                // Use string interpolation syntax to make code clearer.
                writer.WriteLine($"The {company} is {rating} points.");
            }
        }


        static void WriteHTML()
        {
            using (StringWriter stringWriter = new StringWriter())
            using (HtmlTextWriter htmlWriter = new HtmlTextWriter(stringWriter))
            {   htmlWriter.RenderBeginTag(HtmlTextWriterTag.Span);
                htmlWriter.Write("transflower");
                htmlWriter.RenderEndTag();
                Console.WriteLine(stringWriter);
            }
        }


    }
}