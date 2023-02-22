using dotnetflix.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnetflix.Data
{
    public class Dbdotnetflix : DbContext
    {
        public Dbdotnetflix(DbContextOptions<Dbdotnetflix> options) : base(options) { }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Tutorial> Tutorials { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tutorial>()
                .HasOne(a => a.Author);
        }
    }
}