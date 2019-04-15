﻿namespace PEProject_VirtualLibrary.Entities
{
    public class CDRom : Item
    {
        public CDRom()
        {
        }

        public CDRom(string author, string title, string date, string condition)
            : base(author, title, date, condition)
        {
        }

        public CDRom(string author, string title, string style, string date, string condition)
            : base(author, title, style, date, condition)
        { }
    }
}