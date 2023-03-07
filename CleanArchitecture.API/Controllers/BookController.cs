using CleanArchitecture.Infrastracture.Models.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.API.Controllers
{
	[Route("book")]
	public class BookController : Controller
	{
		private readonly IBookRepository repository;

		public BookController(IBookRepository repository) 
		{ 
			this.repository = repository;
		}


		[HttpGet]
		[Route("list")]
		public IActionResult Index()
		{
			return View(this.repository.Books.Include(b => b.Categories).Include(b => b.BookCopies));
		}
	}
}
