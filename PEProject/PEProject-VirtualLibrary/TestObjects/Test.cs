namespace PEProject_VirtualLibrary.TestObjects
{
    using System.Collections.Generic;

    using PEProject_VirtualLibrary.Entities;

    public class Test
    {
        public void AddTestObjects(List<Item> items)
        {
            var item = new Book("Ivan vazov", "Pod igoto", "Roman", "1999", "Free");
            items.Add(item);
            var item2 = new AudioCD("Eminem", "Dadada", "Rap", "2000", "Reserved");
            items.Add(item2);
            var item3 = new CDRom("CD Room1 Author", "CD Room1", "CD", "1980", "Free");
            items.Add(item3);
            var item4 = new Magazine("Magazine1 Author", "Magazine1", "Magazine", "1999", "Free");
            items.Add(item4);
            var item5 = new Diskette("Diskette1 Author", "Diskette1", "Diskette", "1999", "Free");
            items.Add(item5);
            var item6 = new VideoDiskette("Video Diskette Author", "Video Diskette", "2000", "Reserved");
            items.Add(item6);
            var item7 = new VideoDiskette("Video Diskette Author", "Video Diskette", "Video Diskette", "2000", "Reserved");
            items.Add(item7);
        }
    }
}