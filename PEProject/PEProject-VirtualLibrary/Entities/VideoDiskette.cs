namespace PEProject_VirtualLibrary.Entities
{
    using PEProject_VirtualLibrary.Entities.Contracts;

    public class VideoDiskette : Item, IPlayable
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

        public double Length { get; set; } = 100;
    }
}