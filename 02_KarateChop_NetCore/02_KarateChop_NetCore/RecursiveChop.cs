using System;
using System.Collections.Generic;

namespace _02_KarateChop_NetCore
{
    public class RecursiveChop
    {
        public int Chop(int value, int[] input)
        {
            return SearchRecursive(value, input, 0, input.Length - 1);
        }

        private int SearchRecursive(int value, int[] input, int currentMinIndex, int currentMaxIndex)
        {
            if (currentMinIndex > currentMaxIndex)
            {
                return -1;
            }
            if (currentMinIndex == currentMaxIndex)
            {
                return input[currentMinIndex] == value ? currentMinIndex : -1;
            }

            var mid = (currentMinIndex + currentMinIndex + currentMaxIndex) / 2;
            if (value == input[mid])
            {
                return mid;
            }
            else if (value < input[mid])
            {
                return SearchRecursive(value, input, currentMinIndex, mid - 1);
            }
            else
            {
                return SearchRecursive(value, input, mid + 1, currentMaxIndex);
            }
        }
    }
}
