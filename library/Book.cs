using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    class Book
    {
        public int Book_id { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
        public string Date { get; set; }
        public int Pages { get; set; }
        public int Available { get; set; }
    

        public Book()
        {
            Book_id = 0;
            Author = "";
            Title = "";
            Type = "";
            Date = "";
            Pages = 0;
            Available = 0;
        }

        public Book(int book_id, string author, string title, string type, string date, int pages, int available)
        {
            Book_id = book_id;
            Author = author;
            Title = title;
            Type = type;
            Date = date;
            Pages = pages;
            Available = available;
        }

        public Book(string author, string title, string type, string date, int pages, int available)
        {
            Book_id = 0;
            Author = author;
            Title = title;
            Type = type;
            Date = date;
            Pages = pages;
            Available = available;
        }
    }
}
