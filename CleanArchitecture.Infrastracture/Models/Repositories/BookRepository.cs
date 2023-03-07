using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastracture.Models.Repositories
{
	public class BookRepository : IBookRepository
	{
		private AppDbContext context;
		public IQueryable<Book> Books => this.context.Books;

		public BookRepository(AppDbContext context) 
		{ 
			this.context = context;
		}

		public void CreateBook(Book book)
		{
			this.context.Add(book);
			this.context.SaveChanges();
		}

		public void DeleteBook(Book book)
		{
			this.context.Remove(book);
			this.context.SaveChanges();
		}

		public void UpdateBook(Book book)
		{
			if (book.Id == 0)
			{
				this.context.Add(book);
			}
			else
			{
				Book? bookToEdit = this.context.Books.FirstOrDefault(b => b.Id == book.Id);

				if (bookToEdit != null)
				{
					bookToEdit.Author = book.Author;
					bookToEdit.CoAuthors = book.CoAuthors;
					bookToEdit.BookCopies = book.BookCopies;
					bookToEdit.Categories = book.Categories;
					bookToEdit.PublicationDate = book.PublicationDate;
					bookToEdit.Title = book.Title;
				}
			}

			this.context.SaveChanges();
		}
	}
}
