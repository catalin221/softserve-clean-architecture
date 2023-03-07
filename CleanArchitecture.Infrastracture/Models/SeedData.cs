using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Infrastracture.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(AppDbContext context)
        {
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Books.Any())
            {
				Category category1 = new Category
				{
					CategoryName = "Classic Literature",
				};

				Category category2 = new Category
				{
					CategoryName = "Fiction",
				};

				Book book1 = new Book
				{
					Title = "To Kill a Mockingbird",
					Author = "Harper Lee",
					PublicationDate = new DateTime(1960, 7, 11),
					CoAuthors = "None",
					Categories = new List<Category> 
					{ 
						category1, category2 
					},
					BookCopies = new List<BookCopy> 
					{
						new BookCopy
						{
							IsBorrowed = true,
							//Borrowings = new List<Borrowing> { borrowing1 }
						},
						new BookCopy
						{
							IsBorrowed = true,
							//Borrowings = new List<Borrowing> { borrowing1 }
						},
					}
				};

				Book book2 = new Book
				{
					Title = "1984",
					Author = "George Orwell",
					PublicationDate = new DateTime(1949, 6, 8),
					CoAuthors = "None",
					Categories = new List<Category> { category1 },
					BookCopies = new List<BookCopy> 
					{
						new BookCopy
						{
							IsBorrowed = true,
							//Borrowings = new List<Borrowing> { borrowing2 }
						},
						new BookCopy
						{
							IsBorrowed = true,
							//Borrowings = new List<Borrowing> { borrowing2 }
						},
					}
				};

				context.Books.Add(book1);
				context.Books.Add(book2); 
				context.SaveChanges();
			}
		}
    }
}
