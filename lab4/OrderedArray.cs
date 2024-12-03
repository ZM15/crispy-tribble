using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace л_р3
{
    public class OrderedArray
    {
        private int[] array;
        private int numberOfElements;

        // Дополнительные поля для хранения min и max значений
        public int MinValue { get; private set; }
        public int MaxValue { get; private set; }

        public OrderedArray(int size)
        {
            array = new int[size];
            numberOfElements = 0;
            MinValue = int.MaxValue; // Изначально минимальное значение
            MaxValue = int.MinValue; // Изначально максимальное значение
        }

        public bool Insert(int value)
        {
            if (numberOfElements == array.Length) return false;

            int pos = FindInsertionPosition(value);
            for (int i = numberOfElements; i > pos; i--)
            {
                array[i] = array[i - 1];
            }
            array[pos] = value;
            numberOfElements++;

            // Обновляем min и max
            UpdateMinMax(value);
            return true;
        }

        public bool Delete(int value)
        {
            int index = Array.IndexOf(array, value, 0, numberOfElements);
            if (index == -1) return false;

            // Сдвигаем элементы влево
            for (int i = index; i < numberOfElements - 1; i++)
            {
                array[i] = array[i + 1];
            }
            numberOfElements--;

            // Пересчитываем min и max
            RecalculateMinMax();
            return true;
        }

        public (int Min, int Max) GetMinMax()
        {
            return (MinValue, MaxValue);
        }

        private void UpdateMinMax(int value)
        {
            if (value < MinValue) MinValue = value;
            if (value > MaxValue) MaxValue = value;
        }

        private void RecalculateMinMax()
        {
            MinValue = int.MaxValue;
            MaxValue = int.MinValue;

            for (int i = 0; i < numberOfElements; i++)
            {
                if (array[i] < MinValue) MinValue = array[i];
                if (array[i] > MaxValue) MaxValue = array[i];
            }
        }

        private int FindInsertionPosition(int value)
        {
            int low = 0;
            int high = numberOfElements - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (array[mid] < value)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }
            return low;
        }

        public void Display()
        {
            for (int i = 0; i < numberOfElements; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
