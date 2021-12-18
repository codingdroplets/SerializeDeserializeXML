using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

namespace XmlDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            SerializeObjectToXmlString();

            Console.WriteLine("Process completed...");
            Console.ReadKey();
        }

        private static void SerializeObjectToXmlString()
        {
            var member = new Member
            {
                Name = "John",
                Email = "john@gmail.com",
                Age = 30,
                JoiningDate = DateTime.Now,
                IsPlatinumMember = false
            };

            var xmlSerializer = new XmlSerializer(typeof(Member));
            using (var writer = new StringWriter())
            {
                xmlSerializer.Serialize(writer, member);
                var xmlContent = writer.ToString();
                Console.WriteLine(xmlContent);
                DeserializeXmlStringToObject(xmlContent);
            }
        }

        private static void DeserializeXmlStringToObject(string xmlString)
        {
            var xmlSerializer = new XmlSerializer(typeof(Member));
            using (var reader = new StringReader(xmlString))
            {
                var member = (Member)xmlSerializer.Deserialize(reader);
            }
        }

        private static void SerializeObjectToXmlFile()
        {
            var member = new Member
            {
                Name = "John",
                Email = "john@gmail.com",
                Age = 30,
                JoiningDate = DateTime.Now,
                IsPlatinumMember = false
            };

            var xmlSerializer = new XmlSerializer(typeof(Member));
            using (var writer = new StreamWriter(@"C:\Users\cshoa\Desktop\XmlDemo\xml-files\sampl01.xml"))
            {
                xmlSerializer.Serialize(writer, member);
            }
        }

        private static void SerializeListToXmlFile()
        {
            var memberList = new List<Member>
            {
                new Member
                {
                    Name = "John",
                    Email = "john@gmail.com",
                    Age = 30,
                    JoiningDate = DateTime.Now,
                    IsPlatinumMember = false
                },
                new Member
                {
                    Name = "Peter",
                    Email = "peter@gmail.com",
                    Age = 35,
                    JoiningDate = DateTime.Now,
                    IsPlatinumMember = true
                },
                new Member
                {
                    Name = "David",
                    Email = "david@gmail.com",
                    Age = 25,
                    JoiningDate = DateTime.Now,
                    IsPlatinumMember = true
                },
                new Member
                {
                    Name = "George",
                    Email = "george@gmail.com",
                    Age = 29,
                    JoiningDate = DateTime.Now,
                    IsPlatinumMember = false
                }
            };

            var xmlSerializer = new XmlSerializer(typeof(List<Member>));
            using (var writer = new StreamWriter(@"C:\Users\cshoa\Desktop\XmlDemo\xml-files\sample02.xml"))
            {
                xmlSerializer.Serialize(writer, memberList);
            }
        }

        private static void DeserializeXmlFileToList()
        {
            var xmlSerializer = new XmlSerializer(typeof(List<Member>));
            using(var reader = new StreamReader(@"C:\Users\cshoa\Desktop\XmlDemo\xml-files\sample02.xml"))
            {
                var members = (List<Member>)xmlSerializer.Deserialize(reader);

            }
        }

        private static void DeserializeXmlFileToObject()
        {
            var xmlSerializer = new XmlSerializer(typeof(Member));
            using (var reader = new StreamReader(@"C:\Users\cshoa\Desktop\XmlDemo\xml-files\sampl01.xml"))
            {
                var member = (Member)xmlSerializer.Deserialize(reader);

            }
        }
    }
}