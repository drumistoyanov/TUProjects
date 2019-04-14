namespace PEProject_VirtualLibrary.Entities
{
    using PEProject_VirtualLibrary.Entities.Contracts;

    public class Magazine : Item, IReadable
    {
        public Magazine()
        {
        }

        public Magazine(string author, string title, string date, string condition)
            : base(author, title, date, condition)
        {
        }

        public Magazine(string author, string title, string style, string date, string condition)
            : base(author, title, style, date, condition)
        {
        }

        public int Pages { get; set; } = 100;
    }
}