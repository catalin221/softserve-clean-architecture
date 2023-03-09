namespace CleanArchitecture.Infrastracture.Models.Repositories;

public interface IBorrowingRepository
{
    IQueryable<Borrowing> Borrowings { get; }
}