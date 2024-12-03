using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace л_р5
{
    public class UnsortedArrayBubbleSort
    {
        private int[] array;

        public UnsortedArrayBubbleSort(int size)
        {
            array = new int[size];
            FillArray();
        }

        private void FillArray()
        {
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 1000001);
            }
        }

        public void Sort()
        {
            int comparisons = 0;
            int swaps = 0;

            for (int i = array.Length - 1; i > 1 ; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    comparisons++;
                    if (array[j] > array[j + 1])
                    {
                        swaps++;
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine($"Пузырьковая сортировка: Количество операций сравнения: {comparisons}, Количество операций обмена: {swaps}");
        }
    }
}
