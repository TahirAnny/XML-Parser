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
            
            XmlReader source = XmlReader.Create(pathForSaving);

            try
            {
                XmlSerializer xs = new XmlSerializer(typeof(Export));
                var expData = (Export)xs.Deserialize(source);

                Console.WriteLine("Read Successfull!!!");
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
