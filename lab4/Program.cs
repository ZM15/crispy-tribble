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
       
        OrderedArray orderedArray = new OrderedArray(100);
        Random random = new Random();

        // Заполняем массив случайными числами
        for (int i = 0; i < 10; i++)
        {
            int value = random.Next(1, 101);
            orderedArray.Insert(value);
            Console.WriteLine($"Inserted: {value}");
        }

        orderedArray.Display();

        // Получаем минимальные и максимальные значения
        var (min, max) = orderedArray.GetMinMax();
        Console.WriteLine($"Min: {min}, Max: {max}");

        // Пример удаления
        Console.WriteLine("Удаляем значение: " + min);
        orderedArray.Delete(min);
        orderedArray.Display();

        // Обновляем min и max после удаления
        (min, max) = orderedArray.GetMinMax();
        Console.WriteLine($"Min: {min}, Max: {max}");
        Console.ReadKey();
    }
}