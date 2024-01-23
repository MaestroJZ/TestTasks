﻿
internal class Program
{
    static Queue<int> queue = new Queue<int>();
    static object lockObject = new object();
    private static void Main(string[] args)
    {
        Thread senderThread = new Thread(Producer);
        Thread receiverThread = new Thread(Consumer);

        senderThread.Start();
        receiverThread.Start();

        senderThread.Join();
        receiverThread.Join();
    }
    static void Producer()
    {
        for (int i = 0; i < 10; i++)
        {
            lock (lockObject)
            {
                int item = i + 1;
                queue.Enqueue(item);
                Console.WriteLine($"Отправил элемент: {item}");
                Thread.Sleep(500);
            }
        }
    }

    static void Consumer()
    {
        for (int i = 0; i < 10; i++)
        {
            lock (lockObject)
            {
                if (queue.Count > 0)
                {
                    int item = queue.Dequeue();
                    Console.WriteLine($"Получил элемент: {item}");
                }
            }
            Thread.Sleep(600);
        }
    }
}