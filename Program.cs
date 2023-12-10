// See https://aka.ms/new-console-template for more information
using efCore.DataAccess;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello, World!");

var dbContext = new NorthwindDbContext();
dbContext.Authors.Add(new() { AuthorName = "Jules" });
dbContext.Books.Add(new() { BookName = "book1", Description="Desc"});

//persistent api
dbContext.SaveChanges();