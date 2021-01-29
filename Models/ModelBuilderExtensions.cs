using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace codefirst.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>(entity =>
           {
               entity.HasData(new Author { Id = 1, Name = "J.K. Rowling" });
           });

            modelBuilder.Entity<Book>(entity =>
           {
               entity.HasData(new Book { ISBN = "12345678", AuthorId = 1, Language = "English", Pages = 123, Title = "Harry Potter" });
               entity.HasData(new Book { ISBN = "56789123", AuthorId = 1, Language = "English", Pages = 245, Title = "Harry Potter II" });
           });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasData(new Customer { Id = 1, Firstname = "Jack", Lastname = "Sparrow" });
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasData(
                    new Order { Id = 1, CustomerId = 1, Details = "Sale 1", Total = 19M },
                    new Order { Id = 2, CustomerId = 1, Details = "Sale 2", Total = 9.99M }
                   );
            });
        }
    }
}
