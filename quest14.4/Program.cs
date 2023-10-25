using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quest14._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();

            store.AddArticle(new Article("Товар 1", "Магазин 1", 100));
            store.AddArticle(new Article("Товар 2", "Магазин 2", 200));
            store.AddArticle(new Article("Товар 3", "Магазин 3", 300));

            Console.WriteLine("Введите номер товара:");
            int number = Convert.ToInt32(Console.ReadLine());

            Article articleByNumber = store.GetArticleByNumber(number);
            if (articleByNumber != null)
            {
                Console.WriteLine("Название товара: " + articleByNumber.Title);
                Console.WriteLine("Название магазина: " + articleByNumber.StoreName);
                Console.WriteLine("Стоимость товара: " + articleByNumber.Price + " грн");
            }
            else
            {
                Console.WriteLine("Товар с указанным номером не найден");
            }

            Console.WriteLine("Введите название товара:");
            string title = Console.ReadLine();

            Article articleByName = store.GetArticleByName(title);
            if (articleByName != null)
            {
                Console.WriteLine("Название товара: " + articleByName.Title);
                Console.WriteLine("Название магазина: " + articleByName.StoreName);
                Console.WriteLine("Стоимость товара: " + articleByName.Price + " грн");
            }
            else
            {
                Console.WriteLine("Товар с указанным названием не найден");
            }

            Console.ReadLine();
        }
    }

    class Article
    {
        private string title;
        private string storeName;
        private double price;

        public string Title
        {
            get { return title; }
        }

        public string StoreName
        {
            get { return storeName; }
        }

        public double Price
        {
            get { return price; }
        }

        public Article(string title, string storeName, double price)
        {
            this.title = title;
            this.storeName = storeName;
            this.price = price;
        }
    }

    class Store
    {
        private Article[] articles;

        public Store()
        {
            articles = new Article[0];
        }

        public void AddArticle(Article article)
        {
            Array.Resize(ref articles, articles.Length + 1);
            articles[articles.Length - 1] = article;
        }

        public Article GetArticleByNumber(int number)
        {
            if (number >= 0 && number < articles.Length)
            {
                return articles[number];
            }
            else
            {
                return null;
            }
        }

        public Article GetArticleByName(string name)
        {
            foreach (Article article in articles)
            {
                if (article.Title == name)
                {
                    return article;
                }
            }

            return null;
        }
    }
}
