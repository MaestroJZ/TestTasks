class Program
{
    static void Main()
    {
        Console.WriteLine("Выберите единицы измерения температуры:");
        Console.WriteLine("1. Градусы Цельсия");
        Console.WriteLine("2. Градусы Фаренгейта");

        if (int.TryParse(Console.ReadLine(), out int choice))
        {
            if (choice == 1)
            {
                Console.WriteLine("Введите температуру в градусах Цельсия:");
                if (double.TryParse(Console.ReadLine(), out double celsius))
                {
                    double fahrenheit = (celsius * 9 / 5) + 32;
                    Console.WriteLine($"Температура в градусах Фаренгейта: {fahrenheit} °F");
                } else { Console.WriteLine("Что-то не так ввели"); }
            }
            else if (choice == 2)
            {
                Console.WriteLine("Введите температуру в градусах Цельсия:");
                if (double.TryParse(Console.ReadLine(), out double fahrenheit))
                {
                    double celsius = (fahrenheit - 32) * 5 / 9; ;
                    Console.WriteLine($"Температура в градусах Цельсия: {celsius} °C");
                }
                else { Console.WriteLine("Что-то не так ввели"); }
            }
            else { Console.WriteLine("Неверный выбор. Пожалуйста, выберите 1 или 2");}
        } else { Console.WriteLine("Введите цифру от 1 до 2"); }    
    }
}
