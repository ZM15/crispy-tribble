using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace л_р6
{
    public class QueueImpl
    {
        private int maxSize;
        private long[] queueArray;
        private int front;
        private int rear;
        private int nItems;

        public QueueImpl(int size)
        {
            maxSize = size;
            queueArray = new long[maxSize];
            front = 0;
            rear = -1;
            nItems = 0;
        }

        public void Insert(long value)
        {
            if (IsFull())
                throw new InvalidOperationException("Очередь переполнена. Невозможно вставить элемент.");

            if (rear == maxSize - 1)
                rear = -1;

            queueArray[++rear] = value;
            nItems++;
        }

        public long Remove()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Очередь пуста. Невозможно извлечь элемент.");

            long temp = queueArray[front++];
            if (front == maxSize)
                front = 0;

            nItems--;
            return temp;
        }

        public long PeekFront()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Очередь пуста. Невозможно просмотреть первый элемент.");
            return queueArray[front];
        }

        public bool IsEmpty() => (nItems == 0);
        public bool IsFull() => (nItems == maxSize);
        public int Size() => nItems;
    }
}
