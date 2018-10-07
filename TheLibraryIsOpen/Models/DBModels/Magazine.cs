﻿using System;
namespace TheLibraryIsOpen.Models.DBModels
{
    public class Magazine
    {
        public int MagazineId { get; set; }
        public string Title { get; set; }
        public string Publisher { get; set; }
        public string Language { get; set; }
        public string Date { get; set; }
        public string Isbn10 { get; set; }
        public string Isbn13 { get; set; }

        // Default constructor
        public Magazine() { }

        /* Here the constructor assign values to attributes besides MagazineId.
         * The MagazineId is generated by database, when insert an entry to the "magazine" table (assumed it's already & primary key autoincrement).
         * The last id just entered from table would be assigned to MagazineId for the magazine object. So that to avoid same id appears when server gets restarted.
        */
        public Magazine(string title, string publisher, string language, string date, string isbn10, string isbn13)
        {
            Title = title;
            Publisher = publisher;
            Language = language;
            Date = date;
            Isbn10 = isbn10;
            Isbn13 = isbn13;
        }

        // another construcor who assigns magazine id is added as requested.
        public Magazine(int mgId, string title, string publisher, string language, string date, string isbn10, string isbn13)
        {
            MagazineId = mgId;
        }

        // Return information about the magazine
        public override string ToString()
        {
            return "Magazine:\nTitle:" + Title + "\nPublisher:" + Publisher + "\nLanguage:" + Language + "\nDate" + Date +
                "\nISBN10:" + Isbn10 + "\nISBN13:" + Isbn13 + "\nMagazine ID:" + MagazineId;
        }
    }
}
