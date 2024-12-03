using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace л_р6
{
    public class StackImpl
    {
        private int maxSize;
        private char[] stackArray;
        private int top;

        public StackImpl(int size)
        {
            maxSize = size;
            stackArray = new char[maxSize];
            top = -1;
        }

        public void Push(char value)
        {
            if (IsFull())
                throw new InvalidOperationException("Стек переполнен. Невозможно вставить элемент.");
            stackArray[++top] = value;
        }

        public char Pop()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Стек пуст. Невозможно извлечь элемент.");
            return stackArray[top--];
        }

        public char Peek()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Стек пуст. Невозможно просмотреть верхний элемент.");
            return stackArray[top];
        }

        public bool IsEmpty() => (top == -1);
        public bool IsFull() => (top == maxSize - 1);
    }
}
