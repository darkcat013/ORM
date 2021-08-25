using Microsoft.EntityFrameworkCore;
using News.Domain;
using System;

namespace News.CodeFirst
{
    public class NewsDbContext : DbContext
    {
        private const string _connectionString = @"Data Source = .; Initial Catalog = NewsTest; Integrated Security = True";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }

        public DbSet<Article> Articles { get; set; }
        public DbSet<Author> Authors { get; set; }
    }
}
