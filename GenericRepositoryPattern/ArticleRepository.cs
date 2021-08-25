using Microsoft.EntityFrameworkCore;
using News.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepositoryPattern
{
    class ArticleRepository : GenericRepository<Article>, IArticleRepository
    {
        public ArticleRepository() : base() { }
        public IEnumerable<Article> GetByAuthor(Author author)
        {
            return entities.Include(nameof(Author)).Where(a => a.Author.Name == author.Name && a.Author.Surname == author.Surname);
        }

        public Article GetMostLiked()
        {
            var mostLikes = dbContext.Set<Article>().Max(a => a.Likes);
            return dbContext.Set<Article>().First(a => a.Likes == mostLikes);
        }
    }
}
