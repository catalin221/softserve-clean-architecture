using CleanArchitecture.Infrastracture.Models.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.API.Controllers
{
	[Route("Book")]
	public class BookController : Controller
	{
		private readonly IBookRepository repository;

		public BookController(IBookRepository repository) 
		{ 
			this.repository = repository;
		}


		[HttpGet]
		[Route("List")]
		public ViewResult Index()
		{
			return View(this.repository.Books.Include(b => b.Categories).Include(b => b.BookCopies));
		}

		[HttpPost]
		[Route("Delete/{id:long}")]
		public IActionResult Delete(int id)
		{
			var book = repository.Books.Include(b => b.BookCopies).Include(b => b.Categories).FirstOrDefault(b => b.Id == id);
			if (book == null)
			{
				return RedirectToAction("Index");
			}

			this.repository.DeleteBook(book);
			return RedirectToAction("Index");
		}

		[HttpGet]
		[Route("Edit/{id:long}")]
		public IActionResult Edit(int id)
		{
			var book = repository.Books.Include(b => b.BookCopies).Include(b => b.Categories).FirstOrDefault(b => b.Id == id);

			if (book == null)
			{
				return RedirectToAction("Index");
			}

			return View(book);
		}
	}
}
