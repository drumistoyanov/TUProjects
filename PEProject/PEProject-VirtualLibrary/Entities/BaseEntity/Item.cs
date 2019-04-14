namespace PEProject_VirtualLibrary.Entities
{
    using System;
    using System.Globalization;

    using PEProject_VirtualLibrary.Entities.Contracts;
    using PEProject_VirtualLibrary.Entities.Enums;

    public abstract class Item : IItem
    {
        public Item()
        {
        }

        public Item(string author, string title, string style, string date, string condition)
        {
            this.Author = author;
            this.Title = title;
            this.Style = style;
            try
            {
                this.YearOfCreation = DateTime.ParseExact(date, "yyyy", CultureInfo.InvariantCulture);
            }
            catch (FormatException)
            {
                Console.WriteLine("{0} is not in the correct format(yyyy)", date);
            }
            this.Condition = (Enums.Condition)Enum.Parse(typeof(Enums.Condition), condition);
            this.Type = this.GetType().Name.ToString();
        }

        public Item(string author, string title, string date, string condition)
        {
            this.Author = author;
            this.Title = title; try
            {
                this.YearOfCreation = DateTime.ParseExact(date, "yyyy", CultureInfo.InvariantCulture);
            }
            catch (FormatException)
            {
                Console.WriteLine("{0} is not in the correct format(yyyy)", date);
            }
            this.Condition = (Enums.Condition)Enum.Parse(typeof(Enums.Condition), condition);
            this.Type = this.GetType().Name.ToString();
        }

        public string Type { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public DateTime YearOfCreation { get; set; }
        public Condition Condition { get; set; }
        public string Style { get; set; }

        public override string ToString()
        {
            if (this.Style == null)
            {
                return $"Type: {this.GetType().Name.ToString()}, Title: {this.Title}, Year of creation: {this.YearOfCreation.Year}" +
                    $", Condition: {this.Condition}";
            }
            else
                return $"Type: {this.GetType().Name.ToString()}, Title: {this.Title}, Year of creation: {this.YearOfCreation.Year}" +
                    $", Condition: {this.Condition}, Style: {this.Style}";
        }
    }
}