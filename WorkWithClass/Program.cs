namespace WorkWithClass
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Book book1 = new Book("Гарри Поттер и философский камень", "Джоан Роулинг", "Фэнтези", 1997);
            Book book2 = new Book("Властелин колец", "Дж. Р. Р. Толкин", "Эпическое фэнтези", 1955);
            Ranobe ranobe1 = new Ranobe("Реинкарнация безработного", "Rifujin na Magonote", "Фэнтези, Исекай", 2012, "Завершен", 321);

            Console.WriteLine("Информация о книгах:\n");
            book1.DisplayInfo();
            Console.WriteLine();
            book2.DisplayInfo();
            Console.WriteLine();
            ranobe1.DisplayInfo();
            Console.WriteLine();

            Console.WriteLine($"Исправим год выпуска книги '{book2.Title}'");
            book2.YearOfPublication = 1954;
            Console.WriteLine("Исправленный год выпуска: " +  book2.YearOfPublication);
        }
    }
}