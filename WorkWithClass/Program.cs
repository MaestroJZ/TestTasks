namespace WorkWithClass
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Book book1 = new Book("Гарри Поттер и философский камень", "Джоан Роулинг", "Фэнтези", 1997);
            Book book2 = new Book("Властелин колец", "Дж. Р. Р. Толкин", "Эпическое фэнтези", 1955);
            Book book3 = new Book("Винни-Пух", "Алан Милн", "Детская повесть", 1926);

            Console.WriteLine("Информация о книгах:\n");
            book1.DisplayInfo();
            book2.DisplayInfo();
            book3.DisplayInfo();
        }
    }
}