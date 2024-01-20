internal class Program
{
    private static void Main(string[] args)
    {
        List<string> tasks = new List<string>();
        string done = " [D]";
        while (true)
        {
            Console.Clear();
            Console.WriteLine("1. Посмотреть задачи");
            Console.WriteLine("2. Добавить задачу");
            Console.WriteLine("3. Отметить задачу");
            Console.WriteLine("4. Удалить задачу");
            Console.WriteLine("5. Закрыть программу");
            Console.Write("Выберите пункт(1-5): ");

            if (int.TryParse(Console.ReadLine(), out int a))
            {
                Console.Clear();
                switch (a)
                {
                    case 1:                         
                        Print(tasks);
                        ReturnToMenu();
                        Console.Clear();
                        break;
                    case 2:
                        Console.Write("Пишите задачу:");                        
                        string? task = Console.ReadLine();
                        task = task?.Trim();
                        if (String.IsNullOrEmpty(task)) { Console.WriteLine("Вы ничего не ввели"); }
                        else { tasks.Add(task); }
                        ReturnToMenu();
                        break;
                    case 3:
                        Print(tasks);
                        if (tasks.Count > 0)
                        {
                            Console.WriteLine("Выберите задачу которую хотите отметить:");
                            if (int.TryParse(Console.ReadLine(), out int id))
                            {
                                if (id > 0 && id <= tasks.Count)
                                {
                                    tasks[id - 1] += done;
                                    Console.WriteLine("Отмечено");
                                }
                                else { Console.WriteLine("Такой задачи нет"); }
                            }
                            else { Console.WriteLine("Что-то не так ввели"); }
                        }                       
                        ReturnToMenu();
                        break;
                    case 4:
                        Print(tasks);
                        if (tasks.Count > 0)
                        {
                            Console.WriteLine("Выберите номер задачи чтобы удалить:");
                            if (int.TryParse(Console.ReadLine(), out int id))
                            {
                                if (id > 0 && id <= tasks.Count)
                                {
                                    tasks.RemoveAt(id - 1);
                                    Console.WriteLine("Успешно удалено");
                                }
                                else { Console.WriteLine("Такой задачи нет"); }
                            }
                            else { Console.WriteLine("Что-то не так ввели"); }
                        }
                        ReturnToMenu();
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Вы закрыли программу");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Напишите цифру от 1 до 5");
                        break;
                }
            } 
            else
            { 
                Console.WriteLine("Напишите цифру от 1 до 5"); 
            }
        }
    }

    static void Print(List<string> tasks)
    {
        if (tasks.Count > 0) {
            Console.WriteLine("Список задач.");
            for (int i = 0; i < tasks.Count; i++) { Console.WriteLine($"[{i+1}] " + tasks[i]); }
        } else { Console.WriteLine("Задач нет"); }
    }
    static void ReturnToMenu()
    {
        Console.WriteLine("Нажмите любую кнопку для выхода в меню");
        Console.ReadKey();
    }
}