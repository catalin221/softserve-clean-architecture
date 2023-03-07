using System.ComponentModel.DataAnnotations;

namespace CleanArchitecture.Infrastracture.Models
{
    public class Borrowing
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        public User User { get; set; }
        [Required]
        public int BookCopyId { get; set; }
        [Required]
        public BookCopy BookCopy { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
