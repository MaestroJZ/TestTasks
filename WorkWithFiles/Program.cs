using System.Reflection.PortableExecutable;
using static System.Net.Mime.MediaTypeNames;

internal class Program
{
    private static void Main(string[] args)
    {
        string str = "";
        string first = "C:\\VS C# Projects\\TestTasks\\WorkWithFiles\\first.txt";
        using (StreamReader reader = new StreamReader(first))
        {
            str = reader.ReadToEnd();
            Console.WriteLine("Файл прочитан");
        }
        Console.WriteLine("""
            Что хотите сдлеать:
            1. Узнать количество слов
            2. Заменить символ или слово
            3. Добавить символ или слово
            4. Просто записать
            """);
        if (int.TryParse(Console.ReadLine(), out int choice))
        {
            switch (choice)
            {
                case 1:
                    string[] words = str.Split(new char[] { ' ', ',', '.', '?', '/', '&', '*', '\t', '\n' });
                    Console.WriteLine("Количество слов в тексте: " + words.Length);
                    WriteToFile(str);
                    break;
                case 2:
                    Console.Write("Введите что хотите поменять:");
                    string tmp_str1 = Console.ReadLine();
                    if (!str.Contains(tmp_str1))
                    {
                        Console.WriteLine("Такого не существует");
                        return;
                    }
                    Console.Write("И на что:");
                    string tmp_str2 = Console.ReadLine();
                    str = str.Replace(tmp_str1, tmp_str2);
                    WriteToFile(str);
                    break;
                case 3:
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
                        WriteToFile(str);
                    }
                    else { Console.WriteLine("Что то не так"); }
                    break;
                case 4:
                    WriteToFile(str);
                    break;
                default:
                    Console.WriteLine("Цифру от 1 до 4");
                    break;
            }
        }
        else { Console.WriteLine("Неправильно ввели"); }
    }

    private static void WriteToFile(string text)
    {
        using (StreamWriter writer = new StreamWriter("C:\\VS C# Projects\\TestTasks\\WorkWithFiles\\second.txt"))
        {
            writer.Write(text);
            Console.WriteLine("Записано в файл");
        }
    }
}