using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastracture.Models.Repositories
{
	public interface IBookRepository
	{
		IQueryable<Book> Books { get; }

		public void CreateBook(Book book);

		public void UpdateBook(Book book);

		public void DeleteBook(Book book);
	}
}
