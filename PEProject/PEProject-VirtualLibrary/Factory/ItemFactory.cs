namespace PEProject_VirtualLibrary.Factory
{
    using System;
    using System.Collections.Generic;

    using PEProject_VirtualLibrary.Entities;

    public class ItemFactory
    {
        public void CreateAndAddItem(List<Item> items, Item item)
        {
            Console.Write("Choose type(Book, AudioCD, CDRom, Diskette, Magazine, VideoDiskette):");
            var type = Console.ReadLine();
            Console.Write("Choose author:");
            var author = Console.ReadLine();
            Console.Write("Choose title:");
            var title = Console.ReadLine();
            Console.Write("Choose year of creation:");
            var date = Console.ReadLine();
            Console.Write("Choose condition (Free or Reserved):");
            var condition = Console.ReadLine();
            Console.Write("Choose style(optional) if you dont add style type no:");
            var style = Console.ReadLine();
            try
            {
                switch (type)
                {
                    case "Book":
                        if (style != "no")
                        {
                            item = new Book(author, title, style, date, condition);
                        }
                        else
                            item = new Book(author, title, date, condition);
                        items.Add(item);
                        break;

                    case "AudioCD":
                        if (style != "no")
                        {
                            item = new AudioCD(author, title, style, date, condition);
                        }
                        else
                            item = new AudioCD(author, title, date, condition);
                        items.Add(item);
                        break;

                    case "CDRom":
                        if (style != "no")
                        {
                            item = new CDRom(author, title, style, date, condition);
                        }
                        else
                            item = new CDRom(author, title, date, condition);
                        items.Add(item);
                        break;

                    case "Diskette":
                        if (style != "no")
                        {
                            item = new Diskette(author, title, style, date, condition);
                        }
                        else
                            item = new Diskette(author, title, date, condition);
                        items.Add(item);
                        break;

                    case "Magazine":
                        if (style != "no")
                        {
                            item = new Magazine(author, title, style, date, condition);
                        }
                        else
                            item = new Magazine(author, title, date, condition);
                        items.Add(item);
                        break;

                    case "VideoDiskette":
                        if (style != "no")
                        {
                            item = new VideoDiskette(author, title, style, date, condition);
                        }
                        else
                            item = new VideoDiskette(author, title, date, condition);
                        items.Add(item);
                        break;

                    default:
                        throw new Exception("Can't create this type of item!!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}