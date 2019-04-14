namespace PEProject_VirtualLibrary.Entities.Contracts
{
    using System;

    using PEProject_VirtualLibrary.Entities.Enums;

    public interface IItem
    {
        string Type { get; set; }
        string Author { get; set; }
        string Title { get; set; }
        string Style { get; set; }
        DateTime YearOfCreation { get; set; }
        Condition Condition { get; set; }
    }
}