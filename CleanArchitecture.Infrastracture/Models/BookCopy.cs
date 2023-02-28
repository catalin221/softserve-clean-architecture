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
        public int Id { get; private set; }

        [Required]
        public int? BookId { get; private set; }

        [Required]
        public Book? Book { get; private set; }

        [Required]
        public bool? IsBorrowed { get; private set; }
    }
}
