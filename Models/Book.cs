using System;

namespace codefirst.Models
{
    public class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Language { get; set; }
        public int Pages { get; set; }
        public int AuthorId { get; set; }

        public virtual Author Author { get; set; }

    }
}