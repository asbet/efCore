using efCore.DataAccess;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello, World!");

var dbContext = new NorthwindDbContext();
dbContext.Authors.Add(new() { AuthorName = "Jules" });
dbContext.Books.Add(new() { BookName = "book1", Description="Desc"});

dbContext.SaveChanges();