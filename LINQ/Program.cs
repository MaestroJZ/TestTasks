internal class Program
{
    private static void Main(string[] args)
    {
        var people = new List<Person>
        {
            new ("Анатолий", 23, "Астана"),
            new ("Борис", 27, "Алматы"),
            new ("Саша", 29, "Астана"),
            new ("Алина", 24, "Алматы"),
            new ("Алеша", 28, "Астана")
        };
        PrintPeople("Список:", people);
        PrintFilteredPeople("Фильтрация имен где длина равно 5:", people.Where(p => p.Name.Length == 5));
        PrintFilteredPeople("Список людей старше 25:", people.Where(p => p.Age > 25));
        PrintPeople("Сортировка по имени:", people.OrderBy(p => p.Name));
        PrintGroupedPeople("Группировка людей по городам:", people.GroupBy(p => p.City));
    }
    private static void PrintPeople(string header, IEnumerable<Person> people)
    {
        Console.WriteLine(header);
        foreach (var person in people)
            Console.WriteLine($"{person.Name} - {person.Age} - {person.City}");
        Console.WriteLine();
    }
    private static void PrintFilteredPeople(string header, IEnumerable<Person> people)
    {
        Console.WriteLine(header);
        foreach (var person in people)
            Console.WriteLine($"{person.Name} - {person.Age} - {person.City}");
        Console.WriteLine();
    }
    private static void PrintGroupedPeople(string header, IEnumerable<IGrouping<string, Person>> groupedPeople)
    {
        Console.WriteLine(header);
        foreach (var cityGroup in groupedPeople)
        {
            Console.WriteLine(cityGroup.Key + ":");
            foreach (var person in cityGroup)
                Console.WriteLine(person.Name);
            Console.WriteLine();
        }
    }
    record class Person(string Name, int Age, string City);
}
