using SafariOnlineFormatConverter.Epub;
using SafariOnlineFormatConverter.Safari;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SafariOnlineFormatConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            var safariSerializer = new XmlSerializer(typeof(Book));
            var epubSerializer = new XmlSerializer(typeof(Package));
            
            var book = (Book) safariSerializer.Deserialize(File.OpenText("metadata.xml"));
            var package = (Package)epubSerializer.Deserialize(File.OpenText("epub-content.xml"));

            //var package2 = CreateTestPackage();
            //var namespaces = new XmlSerializerNamespaces();
            //Package.GetNamespaces().All(kvp => { namespaces.Add(kvp.Key, kvp.Value); return true; });

            //epubSerializer.Serialize(File.AppendText("output.package.txt"), package2, namespaces);

            Console.WriteLine(book.OfflineContents.OfflineUnits[0].Files[0].Url);
            Console.WriteLine(book.OfflineContents.OfflineUnits[0].Tokens.ToString());
            Console.WriteLine(book.OfflineContents.OfflineUnits[0].Role);
            Console.WriteLine(book.OfflineContents.OfflineUnits[1].LinkId);
            
            Console.ReadKey();
        }

        private static Package CreateTestPackage()
        {
            var package = new Package();
            package.Id = "id";
            package.Version = "2.0";
            package.Metadata = new Metadata()
            {
                Creator = new DcCreator() { FileAs = "Thrupp, George Athelstane", Value = "George Athelstane Thrupp" },
                Dates = new DcDate[] { new DcDate() { Value = new DateTime(2015,6,11), Event = "publication" },
                                                                       new DcDate() { Value = new DateTime(2015,6,11,16,40,32,451), Event = "publication" } },
                Identifier = new DcIdentifier() { Id = "id", Scheme = "URI", Value = "http://www.gutenberg.org/ebooks/49194" },
                Language = new DcLanguage() { Type = "dcterms:RFC4646", Value = "en" },
                Meta = new MetadataMeta() { Content = "item1", Name = "cover" },
                Rights = "Public domain in the USA.",
                Source = "http://www.gutenberg.org/files/49194/49194-h/49194-h.htm",
                Title = "The History of Coaches"
            };
            package.Spine = new Spine()
            {
                Toc = "ncx",
                Items = new SpineItem[] { new SpineItem() { Id = "coverpage-wrapper", Linear = "no" }, 
                                          new SpineItem() { Id = "item58", Linear = "yes" },
                                          new SpineItem() { Id = "item59", Linear = "yes" },
                                          new SpineItem() { Id = "item60", Linear = "yes" },
                                          new SpineItem() { Id = "item61", Linear = "yes" },
                                          new SpineItem() { Id = "item62", Linear = "yes" },
                                          new SpineItem() { Id = "item63", Linear = "yes" },
                                          new SpineItem() { Id = "item64", Linear = "yes" } }

            };
            package.Guide = new Guide()
            {
                References = new GuideReference[] { 
                                new GuideReference() { Title = "CONTENTS.", Type = "toc", Url = "@public@vhost@g@gutenberg@html@files@49194@49194-h@49194-h-0.htm.html#pgepubid00002" },
                                new GuideReference() { Title = "Cover", Type = "cover", Url = "wrap0000.html" } }
            };

            return package;
        }
    }
}
