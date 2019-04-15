namespace PEProject_VirtualLibrary.Entities
{
    public class VideoDiskette : Item
    {
        public VideoDiskette()
        {
        }

        public VideoDiskette(string author, string title, string date, string condition)
            : base(author, title, date, condition)
        {
        }

        public VideoDiskette(string author, string title, string style, string date, string condition)
            : base(author, title, style, date, condition)
        {
        }
    }
}