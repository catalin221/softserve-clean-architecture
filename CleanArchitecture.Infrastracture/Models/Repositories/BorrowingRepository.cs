using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastracture.Models.Repositories
{
    public class BorrowingRepository : IBorrowingRepository
    {
        private AppDbContext _context;

        public IQueryable<Borrowing> Borrowings => _context.Set<Borrowing>();

        public BorrowingRepository(AppDbContext context)
        {
            _context = context;
        }
    }
}
