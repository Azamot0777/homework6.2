using System;

namespace Homework6_2
{
    class Book
    {
        public Title name = new Title();
        public Author author = new Author();
        public Content content = new Content();
        public void Show()
        {
            this.name.Show();
            this.author.Show();
            this.content.Show();
        }
    }

    class Title
    {
        public string TitleName { get; set; }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Title is {this.TitleName}");
        }
    }

    class Author
    {
        public void Show()
        {

        }
    }
    class Content
    {
        public void Show()
        {

        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Book newBook = new Book();
            Title bigTitle = new Title();
            newBook.Show();

        }
    }
}
