internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Напишите что хотите: ");
        string? str = Console.ReadLine();
        if (str == null || str == "") 
        {
            Console.WriteLine("Вы ничего не ввели");
            return;
        }
        Console.WriteLine("Какую операцию хотите сделать:");
        Console.WriteLine("""
            1. Подсчет количество символов в строке
            2. Замена подстроки
            3. Разделение строки
            4. Смена регистра
            5. Вставка
            """);
        if (int.TryParse(Console.ReadLine(), out int choice))
        {
            switch (choice)
            {
                case 1:
                    Console.WriteLine($"Количество символов в строке: {str.Length}");
                    break;
                case 2:
                    Console.Write("Введите что хотите поменять:");
                    string tmp_str1 = Console.ReadLine();
                    if (!str.Contains(tmp_str1)) {
                        Console.WriteLine("Такого не существует");
                        return;
                    }
                    Console.Write("И на что:");
                    string tmp_str2 = Console.ReadLine();
                    str = str.Replace(tmp_str1, tmp_str2);
                    Console.WriteLine("Результат: " + str);
                    break;
                case 3:
                    Console.WriteLine("Разделенная строка:");
                    string[] words = str.Split(new char[] { ' ', ',', '.','?','/','&','*'});
                    foreach (string s in words) { Console.WriteLine(s); }
                    break;
                case 4:
                    Console.WriteLine("1. Сделать верхний регистр");
                    Console.WriteLine("2. Сделать нижний регистр");
                    if (!int.TryParse(Console.ReadLine(), out int tmp)) { Console.WriteLine("1 или 2 введите"); return; }
                    if (tmp == 1) { Console.WriteLine(str.ToUpper()); }     
                    else if (tmp == 2) { Console.WriteLine(str.ToLower()); }
                    else { Console.WriteLine("Что то не так"); }
                    break;
                case 5:
                    Console.Write("Введите что хотите добавить:");
                    string tmp_str3 = Console.ReadLine();
                    if (tmp_str3 == null || tmp_str3 == "")
                    {
                        Console.WriteLine("Вы ничего не ввели");
                        return;
                    }
                    Console.Write("И куда хотите(индекс):");
                    if (int.TryParse(Console.ReadLine(), out int tmp_int) && tmp_int >= 0 && tmp_int < str.Length)
                    {
                        str = str.Insert(tmp_int, tmp_str3);
                        Console.WriteLine("Результат: " + str);
                    } 
                    else { Console.WriteLine("Что то не так"); }
                    break;
                default:
                    Console.WriteLine("Цифру от 1 до 5");
                    break;
            }
        } 
        else { Console.WriteLine("Неправильно ввели"); }
        
    }
}