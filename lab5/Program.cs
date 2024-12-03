using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace л_р5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            const int size = 10000;

            var selectionArray = new UnsortedArraySelectionSort(size);
            selectionArray.Sort();

            var bubbleArray = new UnsortedArrayBubbleSort(size);
            bubbleArray.Sort();

            var insertionArray = new UnsortedArrayInsertionSort(size);
            insertionArray.Sort();
            Console.ReadKey();
        }
    }
}
