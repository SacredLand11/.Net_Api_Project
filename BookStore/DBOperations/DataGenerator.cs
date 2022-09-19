using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.DBOperations
{
    public class DataGenerator
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new BookStoreDbContext(serviceProvider.GetRequiredService<DbContextOptions<BookStoreDbContext>>()))
            {
                if (context.Books.Any())
                {
                    return;
                }

                context.Books.AddRange(
                new Book
                {
                    //Id = 1,
                    Title = "Lean Startup",
                    GenreId = 1, //Personal Growth
                    PageCount = 200,
                    PublishDate = new DateTime(2001, 06, 12)
                },
                new Book
                {
                    //Id = 2,
                    Title = "Herland",
                    GenreId = 2, //Science Fiction
                    PageCount = 450,
                    PublishDate = new DateTime(2011, 02, 23)
                },
                new Book
                {
                    //Id = 3,
                    Title = "Dune",
                    GenreId = 2, //Science Fiction
                    PageCount = 450,
                    PublishDate = new DateTime(2004, 01, 11)
                });
                context.SaveChanges();
            }
        }
    }
}
