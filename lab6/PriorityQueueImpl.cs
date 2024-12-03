using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace л_р6
{
    public class PriorityQueueImpl
    {
        private int maxSize;
        private long[] queueArray;
        private int nItems;

        public PriorityQueueImpl(int size)
        {
            maxSize = size;
            queueArray = new long[maxSize];
            nItems = 0;
        }

        public void Insert(long item)
        {
            if (IsFull())
                throw new InvalidOperationException("Приоритетная очередь переполнена. Невозможно вставить элемент.");

            int j;
            if (nItems == 0)
            {
                queueArray[nItems++] = item;
            }
            else
            {
                for (j = nItems - 1; j >= 0; j--)
                {
                    if (item > queueArray[j])
                    {
                        queueArray[j + 1] = queueArray[j];
                    }
                    else
                    {
                        break;
                    }
                }
                queueArray[j + 1] = item;
                nItems++;
            }
        }

        public long Remove()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Приоритетная очередь пуста. Невозможно извлечь элемент.");
            return queueArray[--nItems];
        }

        public long PeekMin()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Приоритетная очередь пуста. Невозможно просмотреть элемент.");
            return queueArray[nItems - 1];
        }

        public bool IsEmpty() => (nItems == 0);
        public bool IsFull() => (nItems == maxSize);
    }
}
