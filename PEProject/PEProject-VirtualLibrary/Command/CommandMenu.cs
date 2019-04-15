namespace PEProject_VirtualLibrary.Command
{
    using System;
    using System.Collections.Generic;

    using PEProject_VirtualLibrary.Entities;
    using PEProject_VirtualLibrary.Factory;
    using PEProject_VirtualLibrary.File;
    using SearchSystem_ZartAlgorithm.Entities;
    using SearchSystem_ZartAlgorithm.LoginAndRegister;

    public class CommandMenu
    {
        public void Menu(List<Item> items, ItemFactory itemFactory, List<User> users)
        {
            Console.WriteLine("0. Exit");
            Console.WriteLine("1. Register");
            Console.WriteLine("2. Login");
            Console.WriteLine("3. Create Item");
            Console.WriteLine("4. Free");
            Console.WriteLine("5. Reserved");
            int command = 3123213;
            string username;
            string password;
            User user = null;

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
                            Console.Write("Choose username: ");
                            username = Console.ReadLine();
                            Console.Write("Choose password: ");
                            password = Console.ReadLine();
                            user = new User(username, password);
                            users.Add(user);
                            Register.Serialize(users);
                            break;
                        case 2:

                            foreach (var deserializedUser in users)
                            {
                                if (user == null)
                                {
                                    Console.Write("Username: ");
                                    username = Console.ReadLine();
                                    Console.Write("Password: ");
                                    password = Console.ReadLine();
                                    if (deserializedUser.Username == username && deserializedUser.Password == password)
                                    {
                                        user = deserializedUser;
                                    }
                                    if (deserializedUser.Username != username)
                                    {
                                        Console.WriteLine("Wrong username!!!");
                                    }
                                    if (deserializedUser.Password != password)
                                    {
                                        Console.WriteLine("Wrong password!!!");
                                    }
                                    if (user == null)
                                    {
                                        throw new Exception("No user with these username and password!!!");
                                    }
                                    Console.WriteLine($"You are logged in as {user.Username}");
                                    break;
                                }
                                else
                                {
                                    throw new Exception($"You are already logged as {user.Username}");
                                }
                            }

                            break;

                        case 3:
                            if (user != null)
                            {


                                itemFactory.CreateAndAddItem(items, item);
                                FileClass.Serialize(items);
                                
                            }
                            else
                            {

                                throw new Exception("You are not logged in!!!");
                            }
                            break;

                        case 4:
                            if (user != null)
                            {


                                for (int i = 0; i < items.Count; i++)
                                {
                                    if (items[i].Condition == Entities.Enums.Condition.Free)
                                    {
                                        j++;
                                        Console.WriteLine($"{j}. {items[i].ToString()}");
                                    }
                                }
                            }
                            else
                            {

                                throw new Exception("You are not logged in!!!");
                            }
                            break;

                        case 5:
                            if (user != null)
                            {

                                for (int i = 0; i < items.Count; i++)
                                {
                                    if (items[i].Condition == Entities.Enums.Condition.Reserved)
                                    {
                                        j++;
                                        Console.WriteLine($"{j}. {items[i].ToString()}");
                                    }
                                }
                            }
                            else
                            {
                                throw new Exception("You are not logged in!!!");
                            }
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