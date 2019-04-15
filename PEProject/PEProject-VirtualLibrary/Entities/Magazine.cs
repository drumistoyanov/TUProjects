namespace PEProject_VirtualLibrary.Entities
{
    public class Magazine : Item
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
    }
}