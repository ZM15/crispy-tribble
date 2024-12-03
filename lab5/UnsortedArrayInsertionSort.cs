using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace л_р5
{
    public class UnsortedArrayInsertionSort
    {
        private int[] array;

        public UnsortedArrayInsertionSort(int size)
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

            for (int i = 1; i < array.Length; i++)
            {
                int key = array[i];
                int j = i;

                while (j > 0 && array[j - 1] >= key)
                {
                    comparisons++;
                    swaps++; // переносим элемент
                    array[j] = array[j-1];
                    j--;
                }
                comparisons++; // последний сравнение в while
                array[j] = key;
            }
            Console.WriteLine($"Сортировка вставками: Количество операций сравнения: {comparisons}, Количество операций обмена: {swaps}");
        }
    }
}
