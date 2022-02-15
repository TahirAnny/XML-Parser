using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Xml;
using System.Xml.Serialization;

namespace XMLParser
{
    class Program
    {
        static void Main(string[] args)
        {
            var startupPath = Helper.GetExecutingAssemblyPath();
            var pathForSaving = startupPath.Parent.FullName + "\\Data\\FileFormat.xml";
            
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(pathForSaving);

            XmlSerializer serializer = new XmlSerializer(typeof(Export));
            List<Export> data = new List<Export>();
            XmlReader source = XmlReader.Create(pathForSaving);

            if (xmlDoc.InnerXml.Length == 0)
            {
                return;
            }
            else
            {
                try
                {
                    while (source.Read())
                    {
                        XmlSerializer xs = new XmlSerializer(typeof(SanctionEntity));
                        //var expData = (Export)xs.Deserialize(source);

                        if (source.NodeType == XmlNodeType.Element &&
                            source.Name == "sanctionEntity")
                        {
                            var expData = (SanctionEntity)xs.Deserialize(source);
                        }
                    }

                    Console.WriteLine("Successfully Done ");
                    Console.ReadKey();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error occured " + ex.InnerException.Message);
                    Console.ReadKey();
                }
                return;
            }
        }
    }
}
