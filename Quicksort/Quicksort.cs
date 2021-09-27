using System;
using System.Collections.Generic;
using System.Text;

namespace Quicksort
{
    public class Quicksort
    {
        public int[] Sort(int[] items, int begin = 0, int end = 0)
        {
            int i = begin;
            int j = end != 0 ? end : items.Length - 1;

            int pivot = items[(begin + end) / 2];
            int aux = 0;

            while (i <= j )
            {
                while (items[i] < pivot && i < end)
                {
                    i++;
                }

                while (items[j] > pivot && j > begin)
                {
                    j--;
                }

                if (i <= j)
                {
                    aux = items[i];
                    items[i] = items[j];
                    items[j] = aux;
                    i++;
                    j--;
                }
            }

            if (j > begin)
            {
                Sort(items, begin, j + 1);
            }

            if (i < end)
            {
                Sort(items, i, end);
            }

            return items;

        }
    }
}
