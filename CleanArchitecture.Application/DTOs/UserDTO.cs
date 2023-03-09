using System.ComponentModel.DataAnnotations;

namespace CleanArchitecture.Application.DTOs
{
    public class UserDTO
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        public string Role { get; set; }

        public DateTime RegistrationDate { get; set; }

        public List<BorrowingDTO> Borrowings { get; set; }
    }
}
