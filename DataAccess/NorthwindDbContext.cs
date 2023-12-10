using efCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace efCore.DataAccess
{
    public class NorthwindDbContext:DbContext
    {
        // public NorthwindDbContext(DbContextOptions<NorthwindDbContext>options):base(options) { }
        public NorthwindDbContext()
        {
            
        }


        public DbSet<Book>  Books { get; set; }
        public DbSet<Author> Authors{ get; set; }
        public DbSet<Review> Reviews{ get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Data Source=(localdb)\\localDB;Initial Catalog=bookStoreSampleDb;" +
            "Integrated Security=True";
            optionsBuilder.UseSqlServer(connectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Model siniflar(POCO) db'ye aktarılırken nasıl bir ilişki kurulucak?\
            modelBuilder.Entity<Book>().Property(b=>b.BookName).IsRequired();
            modelBuilder.Entity<Book>().Property(b => b.Description).HasMaxLength(250);

            modelBuilder.Entity<Review>()
                .HasOne(relatedType => relatedType.Book)
                .WithMany(b=>b.Reviews)
                .HasForeignKey(b=>b.BookId)
                .OnDelete(DeleteBehavior.Restrict);

            
        }

    }
}
