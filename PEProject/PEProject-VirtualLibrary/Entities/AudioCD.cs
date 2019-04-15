namespace PEProject_VirtualLibrary.Entities
{
    public class AudioCD : Item
    {
        public AudioCD()
        {
        }

        public AudioCD(string author, string title, string date, string condition)
            : base(author, title, date, condition)
        {
        }

        public AudioCD(string author, string title, string style, string date, string condition)
            : base(author, title, style, date, condition)
        {
        }
    }
}