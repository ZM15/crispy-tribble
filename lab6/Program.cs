using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace л_р6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Пример работы со стеком
            string input = "лось";
            Console.WriteLine($"Строка \"{input}\" является палиндромом: {PalindromeChecker.IsPalindrome(input)}");

            // Работа с очередью
            /*try
            {
                QueueImpl queue = new QueueImpl(5);
                queue.Insert(10);
                queue.Insert(20);
                Console.WriteLine($"Удаляем элемент из очереди: {queue.Remove()}");
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }

            // Работа с приоритетной очередью
            try
            {
                PriorityQueueImpl priorityQueue = new PriorityQueueImpl(5);
                priorityQueue.Insert(15);
                priorityQueue.Insert(10);
                Console.WriteLine($"Удаляем элемент из приоритетной очереди: {priorityQueue.Remove()}");
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }*/
            Console.ReadKey();
        }
    }

}
