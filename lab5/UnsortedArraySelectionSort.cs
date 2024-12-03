using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace л_р5
{
    public class UnsortedArraySelectionSort
    {
        private int[] array;

        public UnsortedArraySelectionSort(int size)
        {
            array = new int[size];
            FillArray();
        }

        private void FillArray()
        {
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 1000001); // случайные числа от 1 до 1000000
            }
        }

        public void Sort()
        {
            int comparisons = 0;
            int swaps = 0;

            for (int i = 0; i < array.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    comparisons++;
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                }
                if (minIndex != i)
                {
                    swaps++;
                    int temp = array[i];
                    array[i] = array[minIndex];
                    array[minIndex] = temp;
                }
            }
            Console.WriteLine($"Сортировка выбором: Количество операций сравнения: {comparisons}, Количество операций обмена: {swaps}");
        }
    }
}
