using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using News.Domain;

namespace GenericRepositoryPattern
{
    interface IArticleRepository : IGenericRepository<Article>
    {
        Article GetMostLiked();
        IEnumerable<Article> GetByAuthor(Author author);
    }
}
