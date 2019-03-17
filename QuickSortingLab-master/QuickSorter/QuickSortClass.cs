using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSorter
{
    public class QuickSortClass
    {
        public static void QuickSort(int[] array)
        {
            int start = 0;
            int end = array.Length - 1;
            HoareSort(array, start, end);
        }

        static void Swap<W>(ref W firstElement, ref W secondElement)
        {
            W temp;
            temp = firstElement;
            firstElement = secondElement;
            secondElement = temp;
        }

        static void HoareSort(int[] array, int startIndex, int endIndex)
        {
            if (endIndex == startIndex - 1) return;
            if (endIndex == startIndex) return;
            var pivot = array[endIndex];
            var storeIndex = startIndex;
            for (int i = startIndex; i <= endIndex - 1; i++)
                if (array[i] <= pivot)
                {
                    Swap(ref array[i], ref array[storeIndex]);
                    storeIndex++;
                }
            Swap(ref array[storeIndex], ref array[endIndex]);
            if (storeIndex > startIndex)
                HoareSort(array, startIndex, storeIndex - 1);
            if (storeIndex < endIndex)
                HoareSort(array, storeIndex + 1, endIndex);
        }
    }
}
