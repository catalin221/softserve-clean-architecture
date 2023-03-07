using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastracture.Models
{
    public class BookCopy
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public int BookId { get; set; }

        [Required]
        public Book Book { get; set; }

        [Required]
        public bool IsBorrowed { get; set; }

        public List<Borrowing> Borrowings { get; set; }
    }
}
