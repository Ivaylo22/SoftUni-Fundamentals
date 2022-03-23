using System;
using System.Collections.Generic;

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
        public void Edit(string content) {
            this.Content = content;
        }
        public void ChangeAuthor(string author)
        {
            this.Author = author;
        }
        public void Rename(string title)
        {
            this.Title = title;
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
            string[] props = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            Article firstArticle = new Article(props[0], props[1], props[2]);

            int n = int.Parse(Console.ReadLine());
            for (int i = 0 ; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split(": ", StringSplitOptions.RemoveEmptyEntries);
                string action = tokens[0];

                if (action == "Edit")
                {
                    string newContent = tokens[1];
                    firstArticle.Edit(tokens[1]);
                }

                else if (action == "ChangeAuthor")
                {
                    string newAuthor = tokens[1];
                    firstArticle.ChangeAuthor(tokens[1]);
                }

                else if (action == "Rename")
                {
                    string newTitle = tokens[1];
                    firstArticle.Rename(tokens[1]);
                }
            }
            Console.WriteLine(firstArticle.ToString());
        }

    }

}
