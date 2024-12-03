using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace л_р6
{
    public class PalindromeChecker
    {
        public static bool IsPalindrome(string input)
        {
            StackImpl stack = new StackImpl(input.Length);
            // Заполняем стек символами строки
            foreach (char c in input)
            {
                stack.Push(c);
            }

            // Проверяем, является ли строка палиндромом
            foreach (char c in input)
            {
                if (c != stack.Pop())
                {
                    return false; // Не палиндром
                }
            }

            return true; // Палиндром
        }
    }
}
