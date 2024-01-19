internal class Program
{
    private static void Main(string[] args)
    {
        double result;
        Console.Write("a = ");
        if (double.TryParse(Console.ReadLine(), out double a))
        {
            Console.Write("b = ");
            if (double.TryParse(Console.ReadLine(), out double b))
            {
                Console.Write("Операция: ");
                if (char.TryParse(Console.ReadLine(), out char o))
                {
                    switch (o)
                    {
                        case '+':
                            result = a + b;
                            Console.Write($"{a} + {b} = {result}");
                            break;
                        case '-':
                            result = a - b;
                            Console.Write($"{a} - {b} = {result}");
                            break;
                        case '*':
                            result = a * b;
                            Console.Write($"{a} * {b} = {result}");
                            break;
                        case '/':
                            if (b == 0) { Console.Write("На 0 нельзя делить"); }
                            else
                            {
                                result = a / b;
                                Console.Write($"Результат: {result}");
                            }
                            break;
                        default:
                            Console.Write("Неправильно ввели операцию");
                            break;
                    }
                }
                else { Console.Write("Ошибка при вводе операций"); }
            }
            else { Console.Write("Ошибка при вводе b"); }
        }
        else { Console.Write("Ошибка при вводе a"); }
    }
}