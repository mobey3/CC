using _1313.model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _1313.handler
{
    class XmlHandler
    {
     
        public static List<ViewItem> item = new List<ViewItem>();


        static XmlHandler()
        {
            Load();
        }

        public static void Load()
        {
            try
            {
        string booksOutput = File.ReadAllText(@"./View.xml");    
                XElement ViewXElement = XElement.Parse(booksOutput);
                item = (from item in ViewXElement.Descendants("items")
                        select new ViewItem()
                        {
                            Company = item.Element("company").Value,
                            Kinds = item.Element("종류").Value,
                            Division = item.Element("구분").Value,
                            Itemlist = int.Parse(item.Element("두께").Value,
                            Itemlist2 = item.Element("publisher").Value,
                            TotalPrice = int.Parse(item.Element("총견적").Value)

                        }).ToList<ViewItem>();
                
            }
            catch (FileLoadException ex)
            {
                Save();
            }
        }

        public static void Save()
        {
            string booksOutput = "";
            booksOutput += "<Books>\n";
            foreach (var item in item)
            {
                booksOutput += "<book>\n";
                booksOutput += "  <no>" + item.B_No + "</no>\n";
                booksOutput += "  <name>" + item.B_Name + "</name>\n";
                booksOutput += "  <athor>" + item.B_Athor + "</athor>\n";
                booksOutput += "  <publisher>" + item.B_Publisher + "</publisher>\n";
                booksOutput += "</book>\n";
            }
            booksOutput += "</Books>\n";

            File.WriteAllText(@"./Books.xml", booksOutput);
        }


        }
    }
