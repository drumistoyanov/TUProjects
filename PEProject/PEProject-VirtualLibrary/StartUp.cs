namespace PEProject_VirtualLibrary
{
    using PEProject_VirtualLibrary.Command;
    using PEProject_VirtualLibrary.Factory;
    using PEProject_VirtualLibrary.File;

    public class Program
    {
        public static void Main()
        {
            // var items = new List<Item>();
            // var test = new Test();
            //test.AddTestObjects(items);
            var file = FileClass.FromJson();
            var itemFactory = new ItemFactory();
            var commandMenu = new CommandMenu();
            commandMenu.Menu(file, itemFactory);
        }
    }
}