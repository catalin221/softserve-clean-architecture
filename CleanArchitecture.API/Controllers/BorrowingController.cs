using AutoMapper;
using CleanArchitecture.Application.DTOs;
using CleanArchitecture.Infrastracture.Models.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.API.Controllers
{
    [Route("Borrowing")]
    public class BorrowingController : Controller
    {
        private readonly IBorrowingRepository _borrowingRepository;
        private readonly IMapper _mapper;

        public BorrowingController(IBorrowingRepository borrowingRepository, IMapper mapper)
        {
            _borrowingRepository = borrowingRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("List")]
        public IActionResult Index()
        {
            var borrowings = _borrowingRepository.Borrowings
                                .Include(borrowing => borrowing.BookCopy)
                                .Include(borrowing => borrowing.User);
            var borrowingDTOs = _mapper.Map<List<BorrowingDTO>>(borrowings);
            return View(borrowingDTOs);
        }
    }
}
