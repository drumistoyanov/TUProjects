namespace PEProject_VirtualLibrary.Entities
{
    public class Diskette : Item
    {
        public Diskette()
        {
        }

        public Diskette(string author, string title, string date, string condition)
            : base(author, title, date, condition)
        {
        }

        public Diskette(string author, string title, string style, string date, string condition)
            : base(author, title, style, date, condition)
        {
        }
    }
}