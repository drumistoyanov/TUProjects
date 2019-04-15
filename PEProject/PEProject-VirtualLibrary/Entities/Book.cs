namespace PEProject_VirtualLibrary.Entities
{
    public class Book : Item
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
    }
}