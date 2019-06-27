using System;
using System.IO;
using System.Xml;

namespace FileIOTest
{
    class XMLTexWriter
    {
        static void Main()
        {   // Create an array of four Tuples.
            var array = new Tuple<int, string, string, int>[2];
            array[0] = new Tuple<int, string, string, int>(1,"Sameer", "Kulkarni", 10000);
            array[1] = new Tuple<int, string, string, int>(2,"Jeevan", "Tambade", 30000);
            // Use StringWriter as backing for XmlTextWriter.
            using (StringWriter str = new StringWriter())
            using (XmlTextWriter xml = new XmlTextWriter(str))
            {   // Root.
                xml.WriteStartDocument();
                xml.WriteStartElement("List");
                xml.WriteWhitespace("\n");
                // Loop over Tuples.
                foreach (var element in array)
                {   // Write Employee data.
                    xml.WriteStartElement("Employee");
                    xml.WriteElementString("ID", element.Item1.ToString());
                    xml.WriteElementString("First", element.Item2);
                    xml.WriteWhitespace("\n  ");
                    xml.WriteElementString("Last", element.Item3);
                    xml.WriteElementString("Salary", element.Item4.ToString());
                    xml.WriteEndElement();
                    xml.WriteWhitespace("\n");
                }
                // End.
                xml.WriteEndElement();
                xml.WriteEndDocument();
                // Result is a string.
                string result = str.ToString();
                Console.WriteLine("Length: {0}", result.Length);
                Console.WriteLine("Result: {0}", result);
                Console.ReadLine();
            }
        }
    }
}

