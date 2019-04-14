namespace PEProject_VirtualLibrary.Command
{
    using System;
    using System.Collections.Generic;

    using PEProject_VirtualLibrary.Entities;
    using PEProject_VirtualLibrary.Factory;
    using PEProject_VirtualLibrary.File;

    public class CommandMenu
    {
        public void Menu(List<Item> items, ItemFactory itemFactory)
        {
            Console.WriteLine("0. Exit");
            Console.WriteLine("1. Create item and add it to the library");
            Console.WriteLine("2. Show free");
            Console.WriteLine("3. Show reserved");
            Console.WriteLine("4. ");
            Console.WriteLine("5. ");
            int command = 3123213;

            while (command != 0)
            {
                try
                {
                    Console.Write("Choose command:");
                    command = int.Parse(Console.ReadLine());

                    int j = 0;
                    Item item = null;
                    switch (command)
                    {
                        case 1:
                            itemFactory.CreateAndAddItem(items, item);
                            FileClass.Serialize(items);
                            break;

                        case 2:
                            for (int i = 0; i < items.Count; i++)
                            {
                                if (items[i].Condition == Entities.Enums.Condition.Free)
                                {
                                    j++;
                                    Console.WriteLine($"{j}. {items[i].ToString()}");
                                }
                            }
                            break;

                        case 3:
                            for (int i = 0; i < items.Count; i++)
                            {
                                if (items[i].Condition == Entities.Enums.Condition.Reserved)
                                {
                                    j++;
                                    Console.WriteLine($"{j}. {items[i].ToString()}");
                                }
                            }
                            break;

                        case 4:
                            break;

                        case 5:
                            break;

                        default:
                            throw new Exception("Type correct command!!!");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            Console.WriteLine("Bye!!!");
        }
    }
}