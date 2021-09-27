using System;

namespace Quicksort
{
    class Program
    {
        static void Main(string[] args)
        {
            Quicksort qs = new Quicksort();
            int[] items = new int[]
            {
                8, 5, 12, 55, 3, 7, 82, 44, 35, 25, 41, 29, 17
            };

            PrintArray(items);

            var sortedItems = qs.Sort(items, 0, items.Length-1);

            PrintArray(sortedItems);

            Console.ReadKey();

        }

        static void PrintArray(int[] items)
        {
            foreach (var item in items)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();
        }
    }
}
