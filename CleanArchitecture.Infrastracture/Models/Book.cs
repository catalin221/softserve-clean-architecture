using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastracture.Models
{
    public class Book
    {
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public string Author { get; set; } = string.Empty;

        public DateTime PublicationDate { get; set; }

        public List<string> CoAuthors { get; set; } = new List<string>();

        public List<Category>? Categories { get; set; }

        public List<BookCopy>? BookCopies { get; set; }
    }
}
