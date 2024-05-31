
using Jokes.Models;
using Microsoft.EntityFrameworkCore;

namespace Jokes.Data
{
    public class ApplicationDbContext: DbContext
    {
        //The below constructor will pass the options got from the Progrma.cs to the DBContext
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
            
        }
        //For creating a table named Categories on the basis of Model Category using EF Core
        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
                new Category { Id = 2, Name = "SciFi", DisplayOrder = 2 },
                new Category { Id = 3, Name = "History", DisplayOrder = 3 }
                );
        }
    }
}
