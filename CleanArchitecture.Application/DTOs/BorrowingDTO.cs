namespace CleanArchitecture.Application.DTOs
{
    public class BorrowingDTO
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int BookCopyId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
