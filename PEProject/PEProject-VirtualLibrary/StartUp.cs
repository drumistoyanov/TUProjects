namespace PEProject_VirtualLibrary
{
    using System.Collections.Generic;
    using PEProject_VirtualLibrary.Command;
    using PEProject_VirtualLibrary.Factory;
    using PEProject_VirtualLibrary.File;
    using PEProject_VirtualLibrary.TestObjects;
    using SearchSystem_ZartAlgorithm.Entities;
    using SearchSystem_ZartAlgorithm.LoginAndRegister;
    using SearchSystem_ZartAlgorithm.TestUsers;

    public class Program
    {
        public static void Main()
        {
            // var items = new List<Item>();
            // var test = new Test();
            //test.AddTestObjects(items);
            //var users = new List<User>();
            //var testUsers = new TestUsers();
            //testUsers.AddTestObjects(users);
            //Register.Serialize(users);
            var file = FileClass.Deserialize();
            var usersFile = Login.Deserialize();
            var itemFactory = new ItemFactory();
            var commandMenu = new CommandMenu();
            commandMenu.Menu(file, itemFactory,usersFile);
        }
    }
}