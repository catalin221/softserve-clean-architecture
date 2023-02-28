using System.ComponentModel.DataAnnotations;

namespace CleanArchitecture.Infrastracture.Models
{
    public class Borrowing
    {
        [Required]
        public int Id { get; private set; }
        [Required]
        public int? UserId { get; private set; }
        [Required]
        public User? User { get; private set; }
        [Required]
        public int? BookCopyId { get; private set; }
        [Required]
        public BookCopy? BookCopy { get; private set; }
        public DateTime? StartDate { get; private set; }
        public DateTime? EndDate { get; private set; }
        public DateTime? TimeSpent { get; private set; }
    }
}
