using News.CodeFirst;
using News.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace GenericRepositoryPattern
{
    static class Program
    {
        static void Main(string[] args)
        {
            var author = new Author
            {
                CreatedDate = DateTime.Now,
                ModifiedDate = null,
                Name = "Viorel1",
                Surname = "Noroc1"
            };

            var article = new Article
            {
                CreatedDate = DateTime.Now,
                ModifiedDate = null,
                Title = "Some  Title1",
                Content = "A lot of Content1",
                Likes = 125,
                Author = author
            };

            ArticleRepository articleRepository = new ArticleRepository();

            articleRepository.Add(article);
            var mostLiked = articleRepository.GetMostLiked();

            Console.WriteLine($"{mostLiked.Title}");

            var article1 = articleRepository.GetById(1);
            article1.ModifiedDate = DateTime.Now;
            article1.Content = "modified content";
            articleRepository.Update(article1);
            //NewsDbContext context = new NewsDbContext();
            //context.Database.EnsureCreated();

            //context.Set<Article>().Add(article);
            //context.SaveChanges();
        }
    }
}
