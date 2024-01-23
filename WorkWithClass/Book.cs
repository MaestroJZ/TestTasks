using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithClass
{
    internal class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public int YearOfPublication { get; set; }
        public Book(string title, string author, string genre, int yearOfPublication)
        {
            Title = title;
            Author = author;
            Genre = genre;
            YearOfPublication = yearOfPublication;
        }
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Название: {Title}");
            Console.WriteLine($"Автор: {Author}");
            Console.WriteLine($"Жанр: {Genre}");
            Console.WriteLine($"Год публикации: {YearOfPublication}");
        }
    }

    internal class Ranobe : Book
    {
        
        public int NumberOfChapters { get; set; }
        public string Status {  get; set; }

        public Ranobe(string title, string author, string genre, int yearOfPublication, string status, int numberOfChapters)
            : base(title, author, genre, yearOfPublication)
        {
            Status = status;
            NumberOfChapters = numberOfChapters;
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Статус ранобэ: {Status}");
            Console.WriteLine($"Количество глав: {NumberOfChapters}");
        }
    }

}
