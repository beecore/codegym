using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace W8_2_xml
{
    public class ReadWriteFileXML
    {
        public static bool WriteToFile()
        {
            Book book = new Book();
            book.Title = "AAA";
            book.Price = 123.5f;
            try
            {
                XDocument xDoc = XDocument.Load("C:\\MyData\\books.xml");
                XElement newBook = new XElement("book",
                new XElement("title", book.Title),
                new XElement("price", book.Price.ToString()));

                xDoc.Element("bookstore").Add(newBook);
                xDoc.Save("C:\\MyData\\books.xml");
                return true;
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex);
                return false;
            }
        }
        public static void ReadFromFile()
        {
            XmlTextReader reader = new XmlTextReader("C:\\MyData\\books.xml");
            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element:
                        Console.Write("<" + reader.Name);
                        Console.WriteLine(">");
                        break;
                    case XmlNodeType.Text:
                        Console.WriteLine(reader.Value);
                        break;
                    case XmlNodeType.EndElement:
                        Console.Write("</" + reader.Name);
                        Console.WriteLine(">");
                        break;
                }
            }
        }
    }
}
