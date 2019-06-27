using System;
using System.IO;
using System.Xml;

namespace FileIOTest
{
    class XMLTextReader
    {
     static void Main()
        {
            string input = @"<?xml version=""1.0"" encoding=""utf-16""?>
                                <List>
                                <Employee>
                                        <ID>1</ID>
                                        <First>Manoj</First>
                                        <Last>Pande</Last>
                                </Employee>
                                <Employee>
                                        <ID>3</ID>
                                        <First>Reena</First>
                                        <Last>Dubey</Last>
                                </Employee>
                                </List>";
            using (StringReader stringReader = new StringReader(input))
            using (XmlTextReader reader = new XmlTextReader(stringReader))
            {
                while (reader.Read())
                {
                    if (reader.IsStartElement())
                    {
                        switch (reader.Name)
                        {
                            case "Employee":
                                Console.WriteLine();
                                break;
                            case "ID":
                                Console.WriteLine("ID: " + reader.ReadString());
                                break;
                            case "First":
                                Console.WriteLine("First: " + reader.ReadString());
                                break;
                            case "Last":
                                Console.WriteLine("Last: " + reader.ReadString());
                                break;
                        }
                    }
                }
            }
            Console.ReadLine();
        }
    }
}