using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using System.Web.UI;
using System.Web.Script.Serialization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            OperationWithFilesTxt gg = new OperationWithFilesTxt();
            gg.ReadFile("C:\\CSharp\\New.txt");
            gg.AddTextToFile("C:\\CSharp\\New.txt", "Add some text");
            gg.FindLines("text", "C:\\CSharp\\New.txt");           


            OperationsWithXML rr = new OperationsWithXML();
            rr.ReadXml("C:\\books.xml");
            rr.AddNode();
            rr.RemoveNode("Pro1");

            OperationWithJSon ff = new OperationWithJSon();

            ff.objectToJson();
            ff.JsonToObject(ff.objectToJson());
            Console.ReadKey();

        }
    }



    class OperationWithFilesTxt
    {

        public string ReadFile(string fileNmae)
        {

            try
            {
                StreamReader sr = new StreamReader(fileNmae);
                {
                    String line = sr.ReadToEnd();

                    Console.WriteLine(line);
                    return line;

                }
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);

                return e.Message;
            }

        }

        public void AddTextToFile(string fileNmae, String testToAdd)
        {
            try
            {
                StreamWriter sw = new StreamWriter(fileNmae, true);
                sw.WriteLine(testToAdd);
                sw.Close();
                Console.WriteLine("next text was added to file " + testToAdd);

            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);

            }

        }

        public List<string> FindLines(string searchKeyword, string fileName)
        {

            string[] textLines = File.ReadAllLines(fileName);
            List<string> results = new List<string>();

            foreach (string line in textLines)

            {
                if (line.Contains(searchKeyword))
                {
                    results.Add(line);
                    Console.WriteLine(line);
                }
            }
            return results;
        }



    }

    public class MyDate
    {
        public int year;
        public int month;
        public int day;
    }

    public class Lad
    {
        public string firstName;
        public string lastName;
        public MyDate dateOfBirth;
    }

    class OperationsWithXML
    {
        public void ReadXml(string fileName)
        {



            XElement booksFromFile = XElement.Load(@"books.xml");
            Console.WriteLine(booksFromFile);



        }

        public void AddNode()
        {
            string tempXml = @"<Projects>  
                    <Project ID='1' Name='project1' />  
                    <Project ID='2' Name='project2' />  
                    <Project> 
                         <Pro1 ID='31' Name='pro1' />  
                         <Pro2 ID='32' Name='pro2' />  
                         <Pro3 ID='33' Name='pro3' /> 
                    </Project>                                        
                    <Project ID='4' Name='project4' />  
                    <Project ID='5' Name='project5' />  
                               </Projects>";

            XDocument xDoc = XDocument.Parse(tempXml);

            var b = xDoc.Descendants("Project").Last();

            b.Parent.Add(
                new XElement("Project",
                    new XAttribute("ID", "6"), new XAttribute("Name", "Project6")
                )
            );



            XmlDocument doc = new XmlDocument();
            doc.Load("books.xml");

            XmlNode mapElement = doc.SelectSingleNode("descendant::Pro2");
           
            XmlElement elem = doc.CreateElement("price");
            elem.InnerText = "19.95";
           
            mapElement.AppendChild(elem);

            doc.Save(Console.Out);
            Console.WriteLine();
         
        }

        public void RemoveNode(string nodToDelete)
        {
            string tempXml = @"<Projects>  
                    <Project ID='1' Name='project1' />  
                    <Project ID='2' Name='project2' />  
                    <Project> 
                         <Pro1 ID='31' Name='pro1' />  
                         <Pro2 ID='32' Name='pro2' />  
                         <Pro3 ID='33' Name='pro3' /> 
                    </Project>                                        
                    <Project ID='4' Name='project4' />  
                    <Project ID='5' Name='project5' />  
                               </Projects>";

            XDocument xDoc = XDocument.Parse(tempXml);
            xDoc.Descendants(nodToDelete)
              .First(a => a.Attribute("ID").Value == "31")
              .Remove();

            Console.WriteLine();
            xDoc.Save(Console.Out);
            Console.WriteLine();

        }



    }

    class OperationWithJSon
    {
        public string objectToJson()
        {
            var obj = new Lad
            {
                firstName = "Markoff",
                lastName = "Chaney",
                dateOfBirth = new MyDate
                {
                    year = 1901,
                    month = 4,
                    day = 30
                }
            };
            var json = new JavaScriptSerializer().Serialize(obj);

            Console.WriteLine(json);
      

            return json;
        }

        public void JsonToObject(string json)
        {
            var obj = new JavaScriptSerializer().Deserialize<Lad>(json);
            Console.WriteLine(obj);
            Console.ReadKey();
        }
    }


}
    





