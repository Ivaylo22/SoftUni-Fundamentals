using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Articles
{

    public class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public Article(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }
        public override string ToString()
        {
            return ($"{this.Title} - {this.Content}: {this.Author}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            List<Article> articles = new List<Article>();


            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] props = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
                Article articleToAdd = new Article(props[0], props[1], props[2]);
                articles.Add(articleToAdd);
            }

            string criteriaToSearch = Console.ReadLine();

            if (criteriaToSearch == "title")
            {
                List<Article> sortedArticles = articles.OrderBy(x => x.Title).ToList();
                Console.WriteLine(String.Join("\n", sortedArticles));
            }
            else if (criteriaToSearch == "content")
            {
                List<Article> sortedArticles = articles.OrderBy(x => x.Content).ToList();
                Console.WriteLine(String.Join("\n", sortedArticles));
            }
            else if (criteriaToSearch == "author")
            {
                List<Article> sortedArticles = articles.OrderBy(x => x.Author).ToList();
                Console.WriteLine(String.Join("\n", sortedArticles));
            }

        }

    }

}
