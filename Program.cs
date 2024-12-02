using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using л_р3;

public class Program
{
    public static void Main(string[] args)
    {
        // Создаем объекты Dog и Cat
        Dog rex = new Dog("Rex");
        Cat sheldon = new Cat("Sheldon");

        // Вызываем уникальные методы классов
        rex.SpeakUp();
        sheldon.SpeakUp();

        // Вызываем общие методы агрегированные в классе Animal
        rex.Move(1, 2);
        sheldon.Move(1, 2);

        // Вызываем общие свойства описанные в классе Animal
        Console.WriteLine(rex.Name);
        Console.WriteLine(rex.BirthDate);

        Console.WriteLine(sheldon.Name);
        Console.WriteLine(sheldon.BirthDate);

        // Пример использования функций для минимального и максимального элемента массива
        int[] numbers = new int[10];
        Random random = new Random();
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(1, 101);
        }
        Console.WriteLine("Случайные числа:");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }

        Console.WriteLine($"\nМинимальное число: {MaxMin.Min(numbers)}");
        Console.WriteLine($"Максимальное число: {MaxMin.Max(numbers)}");
        Console.ReadKey();
    }
}