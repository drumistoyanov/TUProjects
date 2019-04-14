namespace PEProject_VirtualLibrary.Entities
{
    using PEProject_VirtualLibrary.Entities.Contracts;

    public class Book : Item, IReadable
    {
        public Book()
        {
        }

        public Book(string author, string title, string date, string condition)
            : base(author, title, date, condition)
        {
        }

        public Book(string author, string title, string style, string date, string condition)
            : base(author, title, style, date, condition)
        {
        }

        public int Pages { get; set; } = 100;
    }
}