using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastracture.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } = string.Empty;

        [Required]
        public string Author { get; set; } = string.Empty;

        [Required]
        public DateTime PublicationDate { get; set; }

        [Required]
        public string CoAuthors { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Category")]
        public string SelectedCategory { get; set; }
        public List<Category> Categories { get; set; }

        public List<BookCopy> BookCopies { get; set; }
    }
}
